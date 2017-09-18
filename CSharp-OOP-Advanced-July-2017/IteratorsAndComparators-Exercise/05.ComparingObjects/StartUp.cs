using System;
using System.Collections.Generic;

namespace _05.ComparingObjects
{
    public class StartUp
    {
        public static void Main()
        {
            var people = new List<Person>();
            var numberOfEqualPeople = 1;

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                var inputArgs = input.Split();
                var name = inputArgs[0];
                var age = int.Parse(inputArgs[1]);
                var town = inputArgs[2];
                var currentPerson = new Person(name, age, town);

                people.Add(currentPerson);
            }

            var personToCompareWith = int.Parse(Console.ReadLine()) - 1;

            for (int i = 0; i < people.Count; i++)
            {
                if (i != personToCompareWith)
                {
                    if (people[personToCompareWith].CompareTo(people[i]) == 0)
                    {
                        numberOfEqualPeople++;
                    }
                }
            }
            if (numberOfEqualPeople > 1)
            {
                Console.WriteLine($"{numberOfEqualPeople} {people.Count - numberOfEqualPeople} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}