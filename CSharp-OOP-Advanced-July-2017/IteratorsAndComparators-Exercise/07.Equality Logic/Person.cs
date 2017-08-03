using System;

namespace _06.Strategy_Pattern
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            if (this.Name.CompareTo(other.Name) != 0)
            {
                return this.Name.CompareTo(other.Name);
            }
            if (this.Age.CompareTo(other.Age) != 0)
            {
                return this.Age.CompareTo(other.Age);
            }
            return 0;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (Object.ReferenceEquals(this, obj))
            {
                return true;
            }

            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            var other = (Person) obj;

            if (this.Name != other.Name)
            {
                return false;
            }

            if (this.Age != other.Age)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            var nameToInt = 0;

            foreach (var character in this.Name)
            {
                nameToInt += Convert.ToInt32(character);
            }
            return nameToInt + this.Age;
        }
    }
}