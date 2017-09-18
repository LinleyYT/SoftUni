using _08.MilitaryElite.Models.Interfaces;
using System;

namespace _08.MilitaryElite.Models.Classes
{
    public abstract class Soldier : ISoldier
    {
        protected Soldier(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        private int id;
        private string firstName;
        private string lastName;

        public int Id
        {
            get { return this.id; }
            protected set { this.id = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            protected set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            protected set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }
                this.lastName = value;
            }
        }
    }
}