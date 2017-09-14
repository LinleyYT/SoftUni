using System;

namespace _02.VehiclesExtension
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption, double capacity)
        {
            this.TankCapacity = capacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        protected double TankCapacity
        {
            get { return this.tankCapacity; }
            set { this.tankCapacity = value; }
        }

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
                    throw new ArgumentException($"Fuel must be a positive number");
                }
                this.fuelQuantity = value;
            }
        }

        public virtual double Fuel(double fuelAmount)
        {
            if (fuelAmount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (this.FuelQuantity + fuelAmount > TankCapacity)
            {
                throw new ArgumentException("Cannot fit fuel in tank");
            }
            return this.FuelQuantity += fuelAmount;
        }

        public virtual void Drive(double distance)
        {
            if (this.FuelQuantity - distance * this.FuelConsumption < 0)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }

            this.FuelQuantity -= distance * this.FuelConsumption;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }

        public virtual void Drive(double distance, string command)
        {
            if (this.FuelQuantity - distance * this.FuelConsumption < 0)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }

            this.FuelQuantity -= distance * this.FuelConsumption;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:f2}";
        }
    }
}