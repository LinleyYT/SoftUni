using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var input = String.Empty;
        ICollection<IBirthable> listOfInhabitantsWithBirthdays = new List<IBirthable>();

        while ((input = Console.ReadLine()) != "End")
        {
            var inputArgs = input.Split();
            var type = inputArgs[0];

            switch (type)
            {
                case "Citizen":
                    var name = inputArgs[1];
                    var age = int.Parse(inputArgs[2]);
                    var id = inputArgs[3];
                    var birthday = inputArgs[4];
                    IBirthable currentCitizen = new Citizen(name, age, id, birthday);
                    listOfInhabitantsWithBirthdays.Add(currentCitizen);
                    break;
                case "Pet":
                    var namePet = inputArgs[1];
                    var birthdayPet = inputArgs[2];
                    IBirthable currentPet = new Pet(namePet, birthdayPet);
                    listOfInhabitantsWithBirthdays.Add(currentPet);
                    break;
            }
        }

        var yearToCheck = Console.ReadLine();

        foreach (var inhabitant in listOfInhabitantsWithBirthdays.Where(x => x.Birthday.EndsWith(yearToCheck)))
        {
            Console.WriteLine(inhabitant.Birthday);
        }
    }
}

