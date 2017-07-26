using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Google
{
    public class Car
    {
        public string Model { get; set; }
        public string Speed { get; set; }

        public Car(string model, string speed)
        {
            this.Model = model;
            this.Speed = speed;
        }
    }
}
