using _02.Blobs.Interfaces;
using System;
using System.Linq;

namespace _02.Blobs.Core
{
    public class Engine : IRunable
    {
        public Engine(ICommandInterpretable commandInterpreter)
        {
            this.CommandInterpreter = commandInterpreter;
        }

        public ICommandInterpretable CommandInterpreter { get; }

        public void Run()
        {
            string input = String.Empty;

            while ((input = Console.ReadLine()) != "drop")
            {
                var inputArgs = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var commandName = inputArgs[0];
                var data = inputArgs.Skip(1).ToArray();

                Console.WriteLine(this.CommandInterpreter.InterpretCommand(data, commandName).Execute());
            }
        }
    }
}