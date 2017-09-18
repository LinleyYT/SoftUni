using _08.MilitaryElite.Models.Interfaces;
using System;

namespace _08.MilitaryElite.Models.Classes
{
    public class Repair : IRepair
    {
        public Repair(string partName, int hoursWorked)
        {
            this.PartName = partName;
            this.HoursWorked = hoursWorked;
        }

        private string partName;
        private int hoursWorked;

        public int HoursWorked
        {
            get { return this.hoursWorked; }
            set
            {
                if (value > 0)
                {
                    this.hoursWorked = value;
                }
            }
        }

        public string PartName
        {
            get { return this.partName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }
                this.partName = value;
            }
        }

        public override string ToString()
        {
            return $"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
        }
    }
}