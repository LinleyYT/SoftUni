using _08.MilitaryElite.Models.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace _08.MilitaryElite.Models.Classes
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, double salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = new List<IMission>();
        }

        public IList<IMission> Missions { get; }

        public void AddMission(IMission mission)
        {
            this.Missions.Add(mission);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {this.Corps}");
            sb.AppendLine("Missions:");

            foreach (var mission in this.Missions)
            {
                sb.AppendLine($"  {mission.ToString().Trim()}");
            }

            return sb.ToString().Trim();
        }
    }
}