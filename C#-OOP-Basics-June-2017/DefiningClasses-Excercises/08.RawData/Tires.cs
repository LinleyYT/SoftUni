using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RawData
{
    public class Tires
    {
        private double[] tirePressure = new double[4];
        private int[] tireAge = new int[4];

        public double[] TirePressure {
            get { return this.tirePressure; }
            set
            {
                if (value.All(x => x >= 0))
                {
                    this.tirePressure = value;
                }
                else
                {
                    Console.WriteLine("Invalid tire pressure");
                }
            } }

        public int[] Ints
        {
            get { return this.tireAge; }
            set
            {
                if (value.All(x => x >= 0))
                {
                    this.tireAge = value;
                }
                else
                {
                    Console.WriteLine("Invalid tire age");
                }
            }
        }

        public Tires(double[] pressure, int[] age)
        {
            this.tirePressure = pressure;
            this.tireAge = age;
        }
    }
}
