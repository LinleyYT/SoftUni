using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    public class Launcher
    {
        public static void Main()
        {
            var vehicles = new List<Vehicle>();

            var carArgs = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var fuelQuantity = double.Parse(carArgs[1]);
            var fuelConsumption = double.Parse(carArgs[2]);

            Vehicle car = new Car(fuelQuantity, fuelConsumption);
            vehicles.Add(car);

            var truckArgs = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var truckFuelQuantity = double.Parse(truckArgs[1]);
            var truckFuelConsumption = double.Parse(truckArgs[2]);

            Vehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption);
            vehicles.Add(truck);

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                try
                {
                    var commandArgs = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var command = commandArgs[0];
                    var vehicleType = commandArgs[1];
                    var distanceOrFuel = double.Parse(commandArgs[2]);

                    if (vehicleType == "Car")
                    {
                        ExecuteAction(car, command, distanceOrFuel);
                    }
                    else
                    {
                        ExecuteAction(truck, command, distanceOrFuel);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

        private static void ExecuteAction(Vehicle vehicle, string command, double distanceOrFuel)
        {
            switch (command)
            {
                case "Drive":
                    vehicle.Drive(distanceOrFuel);
                    break;
                case "Refuel":
                    vehicle.Fuel(distanceOrFuel);
                    break;
            }
        }
    }
}
