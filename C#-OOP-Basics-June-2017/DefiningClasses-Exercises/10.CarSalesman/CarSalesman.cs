using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CarSalesman
{
    class CarSalesman
    {
        public static void Main()
        {
            var engines = new List<Engine>();
            var cars = new List<Car>();

            var n = int.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < n; i++)
            {
                var engineSpecs = Console.ReadLine().Trim().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var model = engineSpecs[0];
                var power = engineSpecs[1];

                var engine = new Engine(model, power);

                if (engineSpecs.Length > 2)
                {
                    if (double.TryParse(engineSpecs[2], out double result))
                    {
                        engine.Displacement = result.ToString();
                    }
                    else
                    {
                        engine.Efficiency = engineSpecs[2];
                    }
                }
                if (engineSpecs.Length > 3)
                {
                    engine.Efficiency = engineSpecs[3];
                }

                engines.Add(engine);
            }

            var m = int.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < m; i++)
            {
                var carSpecs = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var model = carSpecs[0];
                var engineModel = carSpecs[1];
                var engine = engines.Where(x => x.Model == engineModel).FirstOrDefault();

                var car = new Car(model, engine);

                if (carSpecs.Length > 2)
                {
                    if (double.TryParse(carSpecs[2], out double result))
                    {
                        car.Weight = result.ToString();
                    }
                    else
                    {
                        car.Color = carSpecs[2];
                    }
                }
                if (carSpecs.Length > 3)
                {
                    car.Color = carSpecs[3];
                }
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
