using System;
using System.Linq;

namespace _10.CreateCustomClassAttribute
{
    public class Engine
    {
        public Engine()
        {
            this.WeaponCustomAttribute = (WeaponCustomAttribute) typeof(Weapon).GetCustomAttributes(false).First();
        }

        public WeaponCustomAttribute WeaponCustomAttribute { get; private set; }

        public void Run()
        {
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                ExecuteCommand(input);
            }
        }

        private void ExecuteCommand(string input)
        {
            switch (input)
            {
                case "Author":
                    Console.WriteLine($"Author: {WeaponCustomAttribute.Author}");
                    break;

                case "Revision":
                    Console.WriteLine($"Revision: {WeaponCustomAttribute.Revisions}");
                    break;

                case "Description":
                    Console.WriteLine($"Class description: {WeaponCustomAttribute.Description}");
                    break;

                case "Reviewers":
                    Console.WriteLine($"Reviewers: {String.Join(", ", WeaponCustomAttribute.Reviewers)}");
                    break;
            }
        }
    }
}