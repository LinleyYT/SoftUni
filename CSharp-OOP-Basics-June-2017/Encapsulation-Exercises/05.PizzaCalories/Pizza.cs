using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PizzaCalories
{
    public class Pizza
    {
        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.toppings = new List<Topping>();
        }

        private string name;

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length > 15 || value.Length < 1)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        private List<Topping> toppings;

        public IReadOnlyList<Topping> Toppings
        {
            get { return this.toppings.AsReadOnly(); }
        }

        private Dough dough;

        public Dough Dough
        {
            get { return this.dough; }
            set { this.dough = value; }
        }

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            else
            {
                this.toppings.Add(topping);
            }
        }

        public double GetTotalCalories()
        {
            var totalCalories = this.Dough.GetCalories();
            totalCalories += this.Toppings.Sum(x => x.GetCalories());
            return totalCalories;
        }
    }
}