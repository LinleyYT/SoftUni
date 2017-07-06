using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RawData
{
    public class RawData
    {
        public static void Main()
        {
            var carList = new List<Car>();
            var n = int.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < n; i++)
            {
                var inputArgs = Console.ReadLine().Trim().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var model = inputArgs[0];
                var engineSpeed = int.Parse(inputArgs[1]);
                var enginePower = int.Parse(inputArgs[2]);
                var weight = int.Parse(inputArgs[3]);
                var type = inputArgs[4];
                var pressureOne = double.Parse(inputArgs[5]);
                var ageOne = int.Parse(inputArgs[6]);
                var pressureTwo = double.Parse(inputArgs[7]);
                var ageTwo = int.Parse(inputArgs[8]);
                var pressureThree = double.Parse(inputArgs[9]);
                var ageThree = int.Parse(inputArgs[10]);
                var pressureFour = double.Parse(inputArgs[11]);
                var ageFour = int.Parse(inputArgs[12]);

                var tirePressure = new double[4] { pressureOne, pressureTwo, pressureThree, pressureFour };
                var tireAge = new int[4] { ageOne, ageTwo, ageThree, ageFour };

                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(weight, type);
                var tires = new Tires(tirePressure, tireAge);
                var car = new Car(model, engine, cargo, tires);

                carList.Add(car);
            }

            var command = Console.ReadLine().Trim();

            if (command == "fragile")
            {
                foreach (var car in carList.Where(x => x.Cargo.Type == "fragile").Where(x => x.TireSpecs.TirePressure.Any(t => t < 1)))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (command == "flamable")
            {
                foreach (var car in carList.Where(x => x.Cargo.Type == "flamable").Where(x => x.Engine.EnginePower > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
