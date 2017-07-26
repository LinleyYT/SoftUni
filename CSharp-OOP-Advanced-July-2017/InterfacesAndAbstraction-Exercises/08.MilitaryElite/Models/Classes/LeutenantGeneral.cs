using System;
using System.Collections.Generic;
using System.Text;
using _08.MilitaryElite.Models.Interfaces;

namespace _08.MilitaryElite.Models.Classes
{
    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public LeutenantGeneral(int id, string firstName, string lastName, double salary) 
            : base(id, firstName, lastName, salary)
        {
            this.Privates = new List<ISoldier>();
        }

        private IList<ISoldier> privates;

        public IList<ISoldier> Privates
        {
            get { return privates; }
            private set { this.privates = value; }
        }

        public void AddPrivate(ISoldier currentPrivate)
        {
            this.Privates.Add(currentPrivate);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");
            foreach (var soldier in this.Privates)
            {
                sb.AppendLine($"  {soldier}");
            }

            return sb.ToString().Trim();
        }
    }
}
