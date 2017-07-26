using System;

namespace _03.Wild_farm
{
    public class Mouse : Mammal
    {
        public Mouse(string name, string type, double weight, string region) 
            : base(name, type, weight, region)
        {
            this.AnimalName = name;
            this.AnimalType = type;
            this.AnimalWeight = weight;
            this.LivingRegion = region;
        }

        public override string MakeSound()
        {
            return "SQUEEEAAAK!";
        }

        public override void Eat(string foodType, int quantity)
        {
            if (foodType != "Vegetable")
            {
                throw new ArgumentException("Mouses are not eating that type of food!");
            }

            this.FoodEaten += quantity;
        }
    }
}
