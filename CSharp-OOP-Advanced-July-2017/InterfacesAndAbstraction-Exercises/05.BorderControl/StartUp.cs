using System;
using System.Collections;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        var input = String.Empty;
        var listOfInhabitants = new List<IInhabitant>();

        while ((input = Console.ReadLine()) != "End")
        {
            var inputArgs = input.Split();

            if (inputArgs.Length == 3)
            {
                var name = inputArgs[0];
                var age = int.Parse(inputArgs[1]);
                var id = inputArgs[2];
                IInhabitant currentCitizen = new Citizen(name, age, id);
                listOfInhabitants.Add(currentCitizen);
            }
            else
            {
                var model = inputArgs[0];
                var id = inputArgs[1];
                IInhabitant currentRobot = new Robot(model, id);
                listOfInhabitants.Add(currentRobot);
            }
        }

        var fakeId = Console.ReadLine();

        foreach (var inhabitant in listOfInhabitants)
        {
            if (inhabitant.Id.EndsWith(fakeId))
            {
                Console.WriteLine(inhabitant.Id);
            }
        }
    }
}

