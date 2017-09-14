using System;

namespace _01.Vehicles
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        private double fuelQuantity;
        private double fuelConsumption;

        protected double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }

        protected double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{this.GetType().Name} needs refueling");
                }

                this.fuelQuantity = value;
            }
        }

        public virtual double Fuel(double fuelAmount)
        {
            return this.FuelQuantity += fuelAmount;
        }

        public virtual void Drive(double distance)
        {
            this.FuelQuantity -= distance * this.FuelConsumption;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:f2}";
        }
    }
}