using System;

namespace _05.PizzaCalories
{
    public class Topping
    {
        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        private string type;

        private string Type
        {
            get { return this.type; }
            set
            {
                if (value != "meat" && value != "veggies" && value != "cheese" && value != "sauce")
                {
                    throw new ArgumentException($"Cannot place {UppercaseFirst(value)} on top of your pizza.");
                }

                this.type = value;
            }
        }

        private double weight;

        private double Weight
        {
            get { return this.weight; }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{UppercaseFirst(this.Type)} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }

        private double typeMod;

        public double GetCalories()
        {
            switch (this.Type)
            {
                case "meat":
                    typeMod = 1.2;
                    break;

                case "veggies":
                    typeMod = 0.8;
                    break;

                case "cheese":
                    typeMod = 1.1;
                    break;

                case "sauce":
                    typeMod = 0.9;
                    break;
            }

            return 2 * this.Weight * typeMod;
        }

        private static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}