using System;
using System.Linq;

namespace _11.InfernoInfinity.Core
{
    public class Engine
    {
        public Engine()
        {
            this.CommandInterpreter = new CommandInterpreter();
        }

        public CommandInterpreter CommandInterpreter { get; private set; }

        public void Run()
        {
            string input = String.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                var commandArgs = input.Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries);
                ExecuteCommand(commandArgs);
            }
        }

        private void ExecuteCommand(string[] commandArgs)
        {
            try
            {
                var command = commandArgs[0];

                switch (command)
                {
                    case "Create":
                        CommandInterpreter.CreateWeapon(commandArgs.Skip(1).ToArray());
                        break;

                    case "Add":
                        CommandInterpreter.AddToWeapon(commandArgs.Skip(1).ToArray());
                        break;

                    case "Remove":
                        CommandInterpreter.RemoveGem(commandArgs.Skip(1).ToArray());
                        break;

                    case "Print":
                        CommandInterpreter.Print(commandArgs[1]);
                        break;
                }
            }
            catch (Exception e)
            {
            }
        }
    }
}