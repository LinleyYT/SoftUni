using System;

namespace _10.CarSalesman
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        private string weight = "n/a";

        public string Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        private string color = "n/a";

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public override string ToString()
        {
            return String.Format(
                $"{this.Model}:\r\n  {this.Engine.Model}:\r\n    Power: {this.Engine.Power}\r\n    Displacement: {this.Engine.Displacement}\r\n    Efficiency: {this.Engine.Efficiency}\r\n  Weight: {this.Weight}\r\n  Color: {this.Color}");
        }
    }
}