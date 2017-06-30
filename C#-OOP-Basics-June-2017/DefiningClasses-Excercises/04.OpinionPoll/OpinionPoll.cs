using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class OpinionPoll
{
    public static void Main()
    {
        var people = new List<Person>();
        var n = int.Parse(Console.ReadLine().Trim());

        for (int i = 0; i < n; i++)
        {
            var inputArgs = Console.ReadLine().Trim().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var name = inputArgs[0];
            var age = int.Parse(inputArgs[1]);

            var currentPerson = new Person(name, age);
            people.Add(currentPerson);
        }

        foreach (var person in people.Where(x => x.Age > 30).OrderBy(y => y.Name))
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }
}

