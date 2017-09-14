using System;

namespace _02.VehiclesExtension
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double capacity)
            : base(fuelQuantity, fuelConsumption, capacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = capacity;
        }

        private const double BusConsumptionMod = 1.4;

        public override void Drive(double distance, string driveCommande)
        {
            if (this.FuelQuantity - distance * this.FuelConsumption < 0)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }

            this.FuelQuantity -= distance * this.FuelConsumption;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }

        public override void Drive(double distance)
        {
            if (this.FuelQuantity - distance * (this.FuelConsumption + BusConsumptionMod) < 0)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }

            this.FuelQuantity -= distance * (this.FuelConsumption + BusConsumptionMod);
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }
    }
}