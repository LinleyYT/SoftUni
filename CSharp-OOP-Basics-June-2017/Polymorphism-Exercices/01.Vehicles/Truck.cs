namespace _01.Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption + ConsumptionMod;
        }

        private const double ConsumptionMod = 1.6;
        private const double RefuelingPercentageMod = 0.95;

        public override double Fuel(double fuelAmount)
        {
            return this.FuelQuantity += fuelAmount * RefuelingPercentageMod;
        }
    }
}