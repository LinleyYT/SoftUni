using System;

namespace _06.Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, string gender)
            : base(name, age, gender)
        {
            this.AnimalName = name;
            this.Age = age;
            this.Gender = this.genderTomcat;
        }

        private string genderTomcat = "Male";

        public override void ProduceSound()
        {
            Console.WriteLine("Give me one million b***h");
        }
    }
}