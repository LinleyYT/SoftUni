using System;
using System.Collections.Generic;

namespace _07.CustomList
{
    public class CommandInterpreter
    {
        public CommandInterpreter()
        {
            this.CustomList = new CustomList<string>(new List<string>());
            this.Sorter = new Sorter();
        }

        public CustomList<string> CustomList { get; set; }
        public Sorter Sorter { get; set; }

        public void Run()
        {
            var input = String.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                var inputStrings = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                ExecuteCommand(inputStrings);
            }
        }

        private void ExecuteCommand(string[] commandStrings)
        {
            var command = commandStrings[0];

            switch (command)
            {
                case "Add":
                    var elementToAdd = commandStrings[1];
                    CustomList.Add(elementToAdd);
                    break;

                case "Remove":
                    var indexToRemove = int.Parse(commandStrings[1]);
                    CustomList.Remove(indexToRemove);
                    break;

                case "Contains":
                    var containsString = commandStrings[1];
                    CustomList.Contains(containsString);
                    break;

                case "Swap":
                    var indexOne = int.Parse(commandStrings[1]);
                    var indexTwo = int.Parse(commandStrings[2]);
                    CustomList.Swap(indexOne, indexTwo);
                    break;

                case "Greater":
                    var element = commandStrings[1];
                    CustomList.Greater(element);
                    break;

                case "Max":
                    CustomList.Max();
                    break;

                case "Min":
                    CustomList.Min();
                    break;

                case "Print":
                    CustomList.Print();
                    break;

                case "Sort":
                    this.CustomList = Sorter.Sort(CustomList);
                    break;
            }
        }
    }
}