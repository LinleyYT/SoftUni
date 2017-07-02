using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _12.Google
{
    public class Google
    {
        public static void Main()
        {
            var setOfPeople = new HashSet<People>();

            var input = Console.ReadLine();

            while (input != "End")
            {
                var inputArgs = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var name = inputArgs[0];
                var personClass = inputArgs[1];

                if (setOfPeople.All(x => x.Name != name))
                {
                    var person = new People();
                    person.Name = name;

                    switch (personClass)
                    {
                        case "company":
                            person.Company = AddCompany(inputArgs);
                            break;
                        case "pokemon":
                            person.Pokemons = new List<Pokemon>();
                            person.Pokemons.Add(AddPokemon(inputArgs));
                            break;
                        case "parents":
                            person.Parents.Add(AddParents(inputArgs));
                            break;
                        case "children":
                            person.Children.Add(AddChildren(inputArgs));
                            break;
                        case "car":
                            person.Car = AddCar(inputArgs);
                            break;
                    }

                    setOfPeople.Add(person);
                }
                else
                {
                    switch (personClass)
                    {
                        case "company":
                            setOfPeople.FirstOrDefault(x => x.Name == name).Company = AddCompany(inputArgs);
                            break;
                        case "pokemon":
                            setOfPeople.FirstOrDefault(x => x.Name == name).Pokemons.Add(AddPokemon(inputArgs));
                            break;
                        case "parents":
                            setOfPeople.FirstOrDefault(x => x.Name == name).Parents.Add(AddParents(inputArgs));
                            break;
                        case "children":
                            setOfPeople.FirstOrDefault(x => x.Name == name).Children.Add(AddChildren(inputArgs));
                            break;
                        case "car":
                            setOfPeople.FirstOrDefault(x => x.Name == name).Car = AddCar(inputArgs);
                            break;
                    }
                }

                input = Console.ReadLine();
            }

            var singleName = Console.ReadLine();

            foreach (var person in setOfPeople.Where(x => x.Name == singleName))
            {
                Console.WriteLine($"{person.Name}");
                Console.WriteLine("Company:");
                if (person.Company != null)
                {
                    Console.WriteLine($"{person.Company.Name} {person.Company.Department} {person.Company.Salary:f2}");
                }
                Console.WriteLine("Car:");
                if (person.Car != null)
                {
                    Console.WriteLine($"{person.Car.Model} {person.Car.Speed}");
                }
                Console.WriteLine("Pokemon:");
                if (person.Pokemons != null)
                {
                    foreach (var pokemon in person.Pokemons)
                    {
                        Console.WriteLine($"{pokemon.Name} {pokemon.Type}");
                    }
                }
                Console.WriteLine("Parents:");
                if (person.Parents != null)
                {
                    foreach (var parent in person.Parents)
                    {
                        Console.WriteLine($"{parent.Name} {parent.Birthday}");
                    }
                }
                Console.WriteLine("Children:");
                if (person.Children != null)
                {
                    foreach (var children in person.Children)
                    {
                        Console.WriteLine($"{children.Name} {children.Birthday}");
                    }
                }
            }
        }

        private static Car AddCar(string[] inputArgs)
        {
            var model = inputArgs[2];
            var speed = inputArgs[3];

            return new Car(model, speed);
        }

        private static Children AddChildren(string[] inputArgs)
        {
            var name = inputArgs[2];
            var birthday = inputArgs[3];

            return new Children(name, birthday);
        }

        private static Parents AddParents(string[] inputArgs)
        {
            var name = inputArgs[2];
            var birthday = inputArgs[3];

            return new Parents(name, birthday);
        }

        private static Pokemon AddPokemon(string[] inputArgs)
        {
            var name = inputArgs[2];
            var type = inputArgs[3];

            return new Pokemon(name, type);
        }

        public static Company AddCompany(string[] inputArgs)
        {
            var name = inputArgs[2];
            var department = inputArgs[3];
            var salary = decimal.Parse(inputArgs[4]);

            return new Company(name, department, salary);
        }
    }
}
