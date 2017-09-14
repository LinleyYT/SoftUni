using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Animals
{
    public class Launcher
    {
        public static void Main()
        {
            var listOfAnimals = new List<Animal>();

            string input;
            while ((input = Console.ReadLine()) != "Beast!")
            {
                try
                {
                    var animalType = input;
                    var animalArgs = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                    if (animalArgs.Length < 3 || animalArgs.Any(String.IsNullOrWhiteSpace))
                    {
                        throw new ArgumentException("Invalid input!");
                    }

                    var name = animalArgs[0];
                    var age = int.Parse(animalArgs[1]);
                    var gender = animalArgs[2];

                    var currentAnimal = InstantiateAnimal(animalType, name, age, gender);

                    if (currentAnimal == null)
                    {
                        throw new ArgumentException("Invalid input!");
                    }
                    listOfAnimals.Add(currentAnimal);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            foreach (var animal in listOfAnimals)
            {
                Console.WriteLine(animal);
                animal.ProduceSound();
            }
        }

        private static Animal InstantiateAnimal(string animalType, string name, int age, string gender)
        {
            switch (animalType)
            {
                case "Dog":
                    return new Dog(name, age, gender);

                case "Cat":
                    return new Cat(name, age, gender);

                case "Frog":
                    return new Frog(name, age, gender);

                case "Kittens":
                    return new Kitten(name, age, gender);

                case "Tomcat":
                    return new Tomcat(name, age, gender);

                default:
                    return null;
            }
        }
    }
}