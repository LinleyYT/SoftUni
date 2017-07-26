using System.Runtime.CompilerServices;
using _10.Explicit_Interfaces.Models.Interfaces;

namespace _10.Explicit_Interfaces.Models
{
    public class Citizen : IPerson, IResident
    {
        public Citizen(string name, string country, string age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }

        private string name;

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public string Country { get; }

        public string Age { get; }

        string IPerson.Name
        {
            get { return Name; }
        }


        string IResident.Name
        {
            get { return Name; }
        }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }

        string IPerson.GetName()
        {
            return this.Name;
        }
    }
}