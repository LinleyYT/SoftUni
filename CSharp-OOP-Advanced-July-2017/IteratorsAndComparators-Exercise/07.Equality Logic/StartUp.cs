using _06.Strategy_Pattern;
using System;
using System.Collections.Generic;

namespace _07.Equality_Logic
{
    public class StartUp
    {
        public static void Main()
        {
            var sortedSet = new SortedSet<Person>();
            var hashSet = new HashSet<Person>();
            var numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                var inputArgs = Console.ReadLine().Split();
                var name = inputArgs[0];
                var age = int.Parse(inputArgs[1]);

                var currentPerson = new Person(name, age);

                sortedSet.Add(currentPerson);
                hashSet.Add(currentPerson);
            }

            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count);
        }
    }
}