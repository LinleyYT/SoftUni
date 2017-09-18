using _08.MilitaryElite.Models.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace _08.MilitaryElite.Models.Classes
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(int id, string firstName, string lastName, double salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = new List<IRepair>();
        }

        public IList<IRepair> Repairs { get; }

        public void AddRepair(IRepair repair)
        {
            this.Repairs.Add(repair);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {this.Corps}");
            sb.AppendLine("Repairs:");

            foreach (var repair in this.Repairs)
            {
                sb.AppendLine($"  {repair.ToString().Trim()}");
            }

            return sb.ToString().Trim();
        }
    }
}