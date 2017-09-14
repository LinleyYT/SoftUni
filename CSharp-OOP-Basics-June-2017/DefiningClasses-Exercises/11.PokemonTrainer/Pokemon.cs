namespace _11.PokemonTrainer
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string Element { get; set; }

        private double health;

        public double Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public Pokemon(string name, string element, double health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }
    }
}