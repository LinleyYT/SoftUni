using System;

namespace _01.Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        {
            base.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption + ConsumptionMod;
        }

        private const double ConsumptionMod = 0.9;

    }
}
