namespace _03.Wild_farm
{
    public abstract class Feline : Mammal
    {
        protected Feline(string name, string type, double weight, string region) 
            : base(name, type, weight, region)
        {
            this.AnimalName = name;
            this.AnimalType = type;
            this.AnimalWeight = weight;
            this.LivingRegion = region;
        }
    }
}
