using System;

namespace _06.Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string gender) 
            : base(name, age, gender)
        {
            this.AnimalName = name;
            this.Age = age;
            this.Gender = gender;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("BauBau");
        }
    }
}
