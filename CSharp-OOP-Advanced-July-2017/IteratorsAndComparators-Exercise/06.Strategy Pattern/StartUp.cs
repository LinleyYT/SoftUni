using _06.Strategy_Pattern.Comparators;
using System;
using System.Collections.Generic;

namespace _06.Strategy_Pattern
{
    public class StartUp
    {
        public static void Main()
        {
            var sortedSetByName = new SortedSet<Person>(new NameComparator());
            var sortedSetByAge = new SortedSet<Person>(new AgeComparer());
            var numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                var inputArgs = Console.ReadLine().Split();
                var name = inputArgs[0];
                var age = int.Parse(inputArgs[1]);

                var currentPerson = new Person(name, age);

                sortedSetByName.Add(currentPerson);
                sortedSetByAge.Add(currentPerson);
            }

            foreach (var person in sortedSetByName)
            {
                Console.WriteLine(person);
            }

            foreach (var person in sortedSetByAge)
            {
                Console.WriteLine(person);
            }
        }
    }
}