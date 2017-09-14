namespace _10.CarSalesman
{
    public class Engine
    {
        public string Model { get; set; }
        public string Power { get; set; }

        private string displacement = "n/a";

        public string Displacement
        {
            get { return this.displacement; }
            set { this.displacement = value; }
        }

        private string efficiency = "n/a";

        public string Efficiency
        {
            get { return this.efficiency; }
            set { this.efficiency = value; }
        }

        public Engine(string model, string power)
        {
            this.Model = model;
            this.Power = power;
        }
    }
}