using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VehiclesExtension
{
    public class Launcher
    {
        public static void Main()
        {

            var carArgs = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var fuelQuantity = double.Parse(carArgs[1]);
            var fuelConsumption = double.Parse(carArgs[2]);
            var carTankCapacity = double.Parse(carArgs[3]);

            Vehicle car = new Car(fuelQuantity, fuelConsumption, carTankCapacity);
            

            var truckArgs = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var truckFuelQuantity = double.Parse(truckArgs[1]);
            var truckFuelConsumption = double.Parse(truckArgs[2]);
            var truckTankCapacity = double.Parse(truckArgs[3]);

            Vehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);

            var busArgs = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var busFuelQuantity = double.Parse(busArgs[1]);
            var busFuelConsumption = double.Parse(busArgs[2]);
            var busTankCapacity = double.Parse(busArgs[3]);

            Vehicle bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                try
                {
                    var commandArgs = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var command = commandArgs[0];
                    var vehicleType = commandArgs[1];
                    var distanceOrFuel = double.Parse(commandArgs[2]);

                    switch (vehicleType)
                    {
                        case "Car":
                            ExecuteAction(car, command, distanceOrFuel);
                            break;
                        case "Truck":
                            ExecuteAction(truck, command, distanceOrFuel);
                            break;
                        case "Bus":
                            ExecuteAction(bus, command, distanceOrFuel);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
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
                case "DriveEmpty":
                    vehicle.Drive(distanceOrFuel, command);
                    break;
            }
        }
    }
}
