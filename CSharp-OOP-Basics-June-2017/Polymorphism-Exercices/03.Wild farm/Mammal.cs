using System.Text;

namespace _03.Wild_farm
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string name, string type, double weight, string region)
            : base(name, type, weight)
        {
            this.AnimalName = name;
            this.AnimalType = type;
            this.AnimalWeight = weight;
            this.LivingRegion = region;
        }

        private string livingRegion;

        public string LivingRegion
        {
            get { return this.livingRegion; }
            protected set { this.livingRegion = value; }
        }

        public override string ToString()
        {
            return $"{this.AnimalType}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
