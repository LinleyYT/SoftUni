using System;
using System.Reflection;

public class Launcher
{
    public static void Main()
    {
        MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
        MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
        if (oldestMemberMethod == null || addMemberMethod == null)
        {
            throw new Exception();
        }

        var n = int.Parse(Console.ReadLine());

        var family = new Family();

        for (int i = 0; i < n; i++)
        {
            var inputArgs = Console.ReadLine().Trim().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var personName = inputArgs[0];
            var personAge = int.Parse(inputArgs[1]);

            var currentPerson = new Person(personName, personAge);
            family.AddMember(currentPerson);
        }

        var oldestPerson = family.GetOldestMember(family.People);

        Console.WriteLine($"{oldestPerson.name} {oldestPerson.age}");
    }
}