using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.PizzaCalories
{
    public class Dough
    {
        public Dough(string type, string tech, double weight)
        {
            this.FlourType = type;
            this.BakingTech = tech;
            this.Weight = weight;
        }

        private string flourType;

        private string FlourType
        {
            get { return this.flourType; }
            set
            {
                if (value != "white" && value != "wholegrain")
                {
                   throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        private string bakingTech;

        private string BakingTech
        {
            get { return this.bakingTech; }
            set
            {
                if (value != "crispy" && value != "chewy" && value != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTech = value;
            }
        }

        private double weight;

        private double Weight
        {
            get { return this.weight; }
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }


        private double flourTypeMod;
        private double doughTechMod;

        public double GetCalories(string type, string tech)
        {
            switch (type)
            {
                case "white":
                    this.flourTypeMod = 1.5;
                    break;
                case "wholegrain":
                    this.flourTypeMod = 1.0;
                    break;
            }
            
            switch (tech)
            {
                case "crispy":
                    this.doughTechMod = 0.9;
                    break;
                case "chewy":
                    this.doughTechMod = 1.1;
                    break;
                case "homemade":
                    this.doughTechMod = 1.0;
                    break;
            }

            var calsPerGram = 2 * this.Weight * this.flourTypeMod * this.doughTechMod;
            return calsPerGram;
        }


    }

}
