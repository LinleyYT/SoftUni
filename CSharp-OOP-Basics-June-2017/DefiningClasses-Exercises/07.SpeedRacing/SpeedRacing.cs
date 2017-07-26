using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SpeedRacing
{
    public class SpeedRacing
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine().Trim());
            var carList = new List<Car>();
            var uniqeModels = new HashSet<string>();
            var model = String.Empty;

            for (int i = 0; i < n; i++)
            {
                var inputArgs = Console.ReadLine().Trim().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                if (!uniqeModels.Contains(inputArgs[0]))
                {
                    model = inputArgs[0];
                    uniqeModels.Add(inputArgs[0]);
                }

                var fuelAmount = double.Parse(inputArgs[1]);
                var fuelConsumption = double.Parse(inputArgs[2]);

                var currentCar = new Car(model, fuelAmount, fuelConsumption);
                carList.Add(currentCar);
            }

            var command = Console.ReadLine().Trim();

            while (command != "End")
            {
                var commandArgs = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var carModel = commandArgs[1];
                var km = double.Parse(commandArgs[2]);

                var current = carList.Where(x => x.Model == carModel).FirstOrDefault();
                current.Drive(km);

                command = Console.ReadLine().Trim();
            }

            foreach (var car in carList)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.Distance}");
            }
        }
    }
}
