using System;

namespace _06.Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age, string gender) 
            : base(name, age, gender)
        {
            this.AnimalName = name;
            this.Age = age;
            this.Gender = this.genderKitten;
        }

        private string genderKitten = "Female";

        public override void ProduceSound()
        {
            Console.WriteLine("Miau");
        }
    }
}
