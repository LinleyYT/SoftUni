using System;
using System.Collections.Generic;
using _10.Explicit_Interfaces.Models;
using _10.Explicit_Interfaces.Models.Interfaces;

namespace _10.Explicit_Interfaces
{
    public class StartUp
    {
        public static void Main()
        {
            var input = String.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                var inputArgs = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var name = inputArgs[0];
                var country = inputArgs[1];
                var age = inputArgs[2];
                var currentCitizen = new Citizen(name, country, age);

                Console.WriteLine(((IPerson) currentCitizen).GetName());
                Console.WriteLine(((IResident)currentCitizen).GetName());
            }
        }
    }
}
