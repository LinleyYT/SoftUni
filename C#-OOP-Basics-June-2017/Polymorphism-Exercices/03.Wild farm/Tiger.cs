using System;

namespace _03.Wild_farm
{
    public class Tiger : Feline
    {
        public Tiger(string name, string type, double weight, string region) 
            : base(name, type, weight, region)
        {
            this.AnimalName = name;
            this.AnimalType = type;
            this.AnimalWeight = weight;
            this.LivingRegion = region;
        }

        public override string MakeSound()
        {
            return "ROAAR!!!";
        }

        public override void Eat(string foodType, int quantity)
        {
            if (foodType != "Meat")
            {
                throw new ArgumentException("Tigers are not eating that type of food!");
            }

            this.FoodEaten += quantity;
        }
    }
}
