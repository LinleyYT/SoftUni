using System.Collections.Generic;
using System.Linq;
using _08.MilitaryElite.Models.Interfaces;

namespace _08.MilitaryElite.Core
{
    public class DataManager
    {
        public DataManager()
        {
            this.Soldiers = new List<ISoldier>();
        }
        private IList<ISoldier> soldiers;

        public IList<ISoldier> Soldiers
        {
            get { return this.soldiers; }
            private set { this.soldiers = value; }
        }

        public void AddSoldier(ISoldier soldier)
        {
            this.Soldiers.Add(soldier);
        }

        public bool SoldierExists(int soldierId)
        {
            if (this.Soldiers.FirstOrDefault(x => x.Id == soldierId) != null)
            {
                return true;
            }
            return false;
        }

        public ISoldier ReturnPrivateSoldier(int soldierId)
        {
            return this.Soldiers.FirstOrDefault(x => x.Id == soldierId);
        }
    }
}