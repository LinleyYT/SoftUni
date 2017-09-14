using System;

namespace _03.Mankind.Models
{
    public class Human
    {
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        private string firstName;

        public virtual string FirstName
        {
            get { return this.firstName; }
            protected set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length <= 3)
                {
                    throw new ArgumentException($"Expected length at least 4 symbols! Argument: {nameof(firstName)}");
                }
                if (Char.IsLower(value[0]))
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: {nameof(firstName)}");
                }

                this.firstName = value;
            }
        }

        private string lastName;

        public virtual string LastName
        {
            get { return this.lastName; }
            protected set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length <= 2)
                {
                    throw new ArgumentException($"Expected length at least 3 symbols! Argument: {nameof(lastName)}");
                }
                if (Char.IsLower(value[0]))
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: {nameof(lastName)}");
                }

                this.lastName = value;
            }
        }
    }
}