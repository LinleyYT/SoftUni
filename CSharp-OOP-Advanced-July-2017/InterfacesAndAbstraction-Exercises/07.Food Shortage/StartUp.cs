using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        IList<IBuyer> peopleCollection = new List<IBuyer>();

        for (int i = 0; i < n; i++)
        {
            var inputArgs = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var factory = new IBuyerFactory();
            peopleCollection.Add(factory.CreateInhabitant(inputArgs));
        }

        string nameInput = String.Empty;

        while ((nameInput = Console.ReadLine()) != "End")
        {
            if (peopleCollection.Any(x => x.Name == nameInput))
            {
                foreach (var person in peopleCollection.Where(x => x.Name == nameInput))
                {
                    person.BuyFood();
                }
            }
        }

        var totalFoodPurchased = peopleCollection.Sum(x => x.Food);
        Console.WriteLine(totalFoodPurchased);
    }
}

