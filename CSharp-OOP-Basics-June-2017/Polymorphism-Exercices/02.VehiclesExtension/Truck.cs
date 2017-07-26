using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VehiclesExtension
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double capacity)
            : base(fuelQuantity, fuelConsumption, capacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption + ConsumptionMod;
        }

        private const double ConsumptionMod = 1.6;
        private const double RefuelingPercentageMod = 0.95;

        public override double Fuel(double fuelAmount)
        {
            if (fuelAmount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            return this.FuelQuantity += fuelAmount * RefuelingPercentageMod;
        }
    }
}
