namespace _03.Wild_farm
{
    public abstract class Animal
    {
        public Animal(string name, string type, double weight)
        {
            this.AnimalName = name;
            this.AnimalType = type;
            this.AnimalWeight = weight;
        }

        private string animalName;

        public string AnimalName
        {
            get { return this.animalName; }
            protected set { this.animalName = value; }
        }

        private string animalType;

        public string AnimalType
        {
            get { return this.animalType; }
            protected set { this.animalType = value; }
        }

        private double animalWeight;

        public double AnimalWeight
        {
            get { return this.animalWeight; }
            protected set { this.animalWeight = value; }
        }

        private int foodEaten;

        public int FoodEaten
        {
            get { return this.foodEaten; }
            protected set { this.foodEaten = value; }
        }

        public abstract string MakeSound();

        public virtual void Eat(int quantity)
        {
            this.FoodEaten += quantity;
        }

        public virtual void Eat(string type, int quantity)
        {
            this.FoodEaten += quantity;
        }
    }
}