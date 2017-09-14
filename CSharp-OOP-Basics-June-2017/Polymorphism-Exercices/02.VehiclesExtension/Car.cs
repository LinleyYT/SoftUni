namespace _02.VehiclesExtension
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double capacity)
            : base(fuelQuantity, fuelConsumption, capacity)
        {
            base.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption + ConsumptionMod;
            this.TankCapacity = capacity;
        }

        private const double ConsumptionMod = 0.9;
    }
}