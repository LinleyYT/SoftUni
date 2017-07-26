using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RawData
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tires TireSpecs { get; set; }

        public Car(string model, Engine engine, Cargo weight, Tires tireSpecs)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = weight;
            this.TireSpecs = tireSpecs;
        }
    }
}
