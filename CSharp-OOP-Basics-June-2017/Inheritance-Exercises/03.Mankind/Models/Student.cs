using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Mankind.Models
{
    public class Student : Human
    {
        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        private string facultyNumber;

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            private set
            {
                Regex rgx = new Regex(@"^[a-zA-Z0-9]{5,10}$");
                if (!rgx.IsMatch(value))
                {
                    throw new ArgumentException($"Invalid faculty number!");
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"First Name: {this.FirstName}");
            sb.AppendLine($"Last Name: {this.LastName}");
            sb.AppendLine($"Faculty number: {this.FacultyNumber}");

            return sb.ToString();
        }
    }
}