using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mankind.Models
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        private decimal weekSalary;

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            private set
            {
                if (value <= 10)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: {nameof(weekSalary)}");
                }

                this.weekSalary = value;
            }
        }

        private decimal workHoursPerDay;

        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            private set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: {nameof(workHoursPerDay)}");
                }

                this.workHoursPerDay = value;
            }
        }

        public override string ToString()
        {   
            var sb = new StringBuilder();

            sb.AppendLine($"First Name: {this.FirstName}");
            sb.AppendLine($"Last Name: {this.LastName}");
            sb.AppendLine($"Week Salary: {this.WeekSalary:f2}");
            sb.AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}");

            var salaryPerHour = this.WeekSalary / (this.WorkHoursPerDay * 5);

            sb.AppendLine($"Salary per hour: {salaryPerHour:f2}");

            return sb.ToString();
        }
    }
}
