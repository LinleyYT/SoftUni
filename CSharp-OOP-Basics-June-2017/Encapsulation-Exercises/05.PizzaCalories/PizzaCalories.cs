using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.PizzaCalories
{
    public class PizzaCalories
    {
        public static void Main()
        {

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                var pizzaArgs = input.Split().Select(x => x.ToLower()).ToArray();

                try
                {
                    
                    if (pizzaArgs[0] == "dough")
                    {
                        var doughCheck = new Dough(pizzaArgs[1], pizzaArgs[2], double.Parse(pizzaArgs[3]));
                        Console.WriteLine($"{doughCheck.GetCalories():f2}");
                    }
                    else if (pizzaArgs[0] == "topping")
                    {
                        var topping = new Topping(pizzaArgs[1], double.Parse(pizzaArgs[2]));
                        Console.WriteLine($"{topping.GetCalories():f2}");
                    }
                    else if (pizzaArgs[0] == "pizza")
                    {
                        var numberOfToppings = int.Parse(pizzaArgs[2]);

                        if (numberOfToppings < 0 || numberOfToppings > 10)
                        {
                            throw new ArgumentException("Number of toppings should be in range [0..10].");
                        }

                        var pizzaName = pizzaArgs[1];

                        var doughArgs = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();
                        var doughType = doughArgs[1];
                        var doughTech = doughArgs[2];
                        var doughWeight = double.Parse(doughArgs[3]);

                        var dough = new Dough(doughType, doughTech, doughWeight);

                        var pizza = new Pizza(pizzaName, dough);

                        for (int i = 0; i < numberOfToppings; i++)
                        {
                            var toppingArgs = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();
                            var toppingType = toppingArgs[1];
                            var toppingWeight = double.Parse(toppingArgs[2]);

                            var topping = new Topping(toppingType, toppingWeight);
                            pizza.AddTopping(topping);
                        }

                        Console.WriteLine($"{pizza.Name} - {pizza.GetTotalCalories():F2} Calories.");
                    }
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }





        }
    }
}
