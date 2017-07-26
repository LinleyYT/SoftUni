using System.Text;

namespace _03.Wild_farm
{
    class Cat : Feline
    {
        public Cat(string name, string type, double weight, string region, string breed) 
            : base(name, type, weight, region)
        {
            this.AnimalName = name;
            this.AnimalType = type;
            this.AnimalWeight = weight;
            this.LivingRegion = region;
            this.Breed = breed;
        }

        private string breed;

        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        public override string MakeSound()
        {
            return "Meowwww";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(MakeSound());
            sb.Append($"{this.AnimalType}[{this.AnimalName}, {this.Breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]");
            return sb.ToString();
        }
    }
}
