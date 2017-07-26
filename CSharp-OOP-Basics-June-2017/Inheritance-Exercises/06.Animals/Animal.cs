using System;
using System.Text;

namespace _06.Animals
{
    public abstract class Animal
    {
        public Animal(string name, int age, string gender)
        {
            this.AnimalName = name;
            this.Age = age;
            this.Gender = gender;
        }

        private string animalName;

        public string AnimalName
        {
            get { return this.animalName; }
            protected set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.animalName = value;
            }
        }

        private int age;

        public int Age
        {
            get { return this.age; }
            protected set
            {
                // is 0 acceptable?
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.age = value;
            }
        }

        private string gender;

        public string Gender
        {
            get { return this.gender; }
            protected set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.gender = value;
            }
        }

        public abstract void ProduceSound();

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.GetType().Name);
            sb.Append($"{this.AnimalName} {this.Age} {this.Gender}");

            return sb.ToString();
        }
    }
}
