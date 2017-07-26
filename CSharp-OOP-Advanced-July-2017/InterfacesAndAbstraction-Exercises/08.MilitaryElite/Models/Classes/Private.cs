using _08.MilitaryElite.Models.Interfaces;

namespace _08.MilitaryElite.Models.Classes
{
    public class Private : Soldier, IPrivate
    {
        public Private(int id, string firstName, string lastName, double salary) 
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        private double salary;
        
        public double Salary
        {
            get { return salary; }
            protected set
            {
                if (value >= 0.0)
                {
                    this.salary = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}";
        }
    }
}