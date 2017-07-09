using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Wild_farm
{
    public class WildFarm
    {
        public static void Main()
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var animaArgs = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var animalType = animaArgs[0];
                var animalName = animaArgs[1];
                var weight = double.Parse(animaArgs[2]);
                var region = animaArgs[3];


                if (animaArgs.Length > 4)
                {
                    Animal cat = new Cat(animaArgs[1], animaArgs[0], double.Parse(animaArgs[2]), animaArgs[3], animaArgs[4]);

                    var foodArgs = Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    var vegQ = int.Parse(foodArgs[1]);
                    cat.Eat(vegQ);
                    Console.WriteLine(cat);
                }
                else
                {
                    var animal = CreateAnimal(animalType, animalName, weight, region);
                    var foodArgs = Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var type = foodArgs[0];
                    var quantity = int.Parse(foodArgs[1]);
                    Console.WriteLine(animal.MakeSound());
                    try
                    {
                        animal.Eat(type, quantity);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Console.WriteLine(animal);
                }

            }
        }

        private static Animal CreateAnimal(string animalType, string animalName, double weight, string region)
        {
            switch (animalType)
            {
                case "Mouse":
                    return new Mouse(animalName, animalType, weight, region);
                case "Zebra":
                    return new Zebra(animalName, animalType, weight, region);
                case "Tiger":
                    return new Tiger(animalName, animalType, weight, region);
                default:
                    return null;
            }
        }
    }
}
