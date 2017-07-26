using _08.MilitaryElite.Models.Interfaces;

namespace _08.MilitaryElite.Models.Classes
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        protected SpecialisedSoldier(int id, string firstName, string lastName, double salary, string corps) 
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        private string _corps;

        public string Corps
        {
            get { return _corps; }
            protected set
            {
                if (value == "Airforces" || value == "Marines")
                {
                    this._corps = value;
                }
            }
        }
    }
}