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
            try
            {
                string input;

                while ((input = Console.ReadLine()) != "END")
                {
                    var inputArgs = input.Split().Select(x => x.ToLower()).ToArray();
                    var toppingArgs = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();

                    var flour = inputArgs[1];
                    var tech = inputArgs[2];
                    var weight = double.Parse(inputArgs[3]);

                    var dough = new Dough(flour, tech, weight);

                    Console.WriteLine($"{dough.GetCalories(flour, tech):F2}");

                    var type = toppingArgs[1];
                    var toppingWeight = double.Parse(toppingArgs[2]);

                    var topping = new Topping(type, toppingWeight);

                    Console.WriteLine($"{topping.GetCalories(type):F2}");
                }
                
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
