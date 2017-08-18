using System;
using System.Linq;
using System.Reflection;
using RecyclingStation.BusinessLayer.Contracts.Core;
using RecyclingStation.BusinessLayer.Contracts.IO;

namespace RecyclingStation.BusinessLayer.Core
{
    public class Engine : IEngine
    {
        private const string ExitCommand = "TimeToRecycle";

        private IReader consoleReader;
        private IWriter consoleWriter;
        private IRecyclingManager recyclingManager;
        private readonly MethodInfo[] recyclingStationMethodInfos;

        public Engine(IReader consoleReader, IWriter consoleWriter, IRecyclingManager recyclingManager)
        {
            this.consoleReader = consoleReader;
            this.consoleWriter = consoleWriter;
            this.recyclingManager = recyclingManager;
            this.recyclingStationMethodInfos = this.recyclingManager.GetType().GetMethods();
        }

        private string[] SplitStrings(string stringToSplit, params char[] toSplitBy)
        {
            return stringToSplit.Split(toSplitBy, StringSplitOptions.RemoveEmptyEntries);
        }

        public void Run()
        {
            string input = String.Empty;

            while ((input = consoleReader.ReadLine()) != ExitCommand)
            {
                var inputArgs = this.SplitStrings(input, ' ');
                var commandName = inputArgs[0];
                var commandParams = default(string[]);

                if (this.SplitStrings(input, '|').Length >= 2)
                {
                    commandParams = this.SplitStrings(inputArgs[1], '|');
                }

                MethodInfo methodToInvoke = this.recyclingStationMethodInfos
                    .FirstOrDefault(m => m.Name.Equals(commandName, StringComparison.OrdinalIgnoreCase));

                ParameterInfo[] methodParameters = methodToInvoke.GetParameters();
                
                object[] parsedParams = new object[methodParameters.Length];

                for (int i = 0; i < methodParameters.Length; i++)
                {
                    Type currentParamType = methodParameters[i].ParameterType;

                    string toConvert = commandParams[i];

                    parsedParams[i] = Convert.ChangeType(toConvert, currentParamType);
                }

                object result = methodToInvoke.Invoke(this.recyclingManager, parsedParams);

                this.consoleWriter.GatherOutput(result.ToString());
            }

            this.consoleWriter.WriteGatheredOutput();
        }
    }
}