using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ShoppingSpree
{
    public class StartUp
    {
        public static void Main()
        {
            var people = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            var products = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            var listOfPersons = new List<Person>();
            var listOfProducts = new List<Product>();

            try
            {
                foreach (var person in people)
                {
                    var nameMoney = person.Split(new[] {'='}, StringSplitOptions.RemoveEmptyEntries);
                    var name = nameMoney[0];
                    var money = decimal.Parse(nameMoney[1]);


                    var currentPerson = new Person(name, money);
                    listOfPersons.Add(currentPerson);
                }

                foreach (var product in products)
                {
                    var nameCost = product.Split(new[] {'='}, StringSplitOptions.RemoveEmptyEntries);
                    var name = nameCost[0];
                    var cost = decimal.Parse(nameCost[1]);


                    var currentProduct = new Product(name, cost);
                    listOfProducts.Add(currentProduct);

                }

                var command = Console.ReadLine();

                while (command != "END")
                {
                    var commandArgs = command.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    var person = commandArgs[0];
                    var product = commandArgs[1];
                    if (listOfPersons.Count > 0)
                    {
                        listOfPersons.FirstOrDefault(x => x.Name == person)
                            .AddProduct(listOfProducts.FirstOrDefault(x => x.Name == product),
                                listOfProducts.FirstOrDefault(x => x.Name == product).Cost);
                    }

                    command = Console.ReadLine();
                }

                foreach (var person in listOfPersons)
                {
                    var sb = new StringBuilder();
                    sb.Append($"{person.Name} - ");

                    if (person.Products.Count > 0)
                    {
                        foreach (var product in person.Products)
                        {
                            sb.Append($"{product.Name}, ");
                        }

                        Console.WriteLine(sb.ToString().TrimEnd(' ').TrimEnd(','));
                    }
                    else
                    {
                        sb.Append("Nothing bought");
                        Console.WriteLine(sb);
                    }
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NullReferenceException)
            {
                
            }
        }
    }
}
