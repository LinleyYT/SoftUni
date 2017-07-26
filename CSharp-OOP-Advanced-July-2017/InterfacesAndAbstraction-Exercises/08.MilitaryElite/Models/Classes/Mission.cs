using System;
using _08.MilitaryElite.Models.Interfaces;

namespace _08.MilitaryElite.Models.Classes
{
    public class Mission : IMission
    {
        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        private string _codeName;
        private string _state;

        public string CodeName
        {
            get { return _codeName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }
                this._codeName = value;
            }
        }

        public string State
        {
            get { return _state; }
            set
            {
                if (value == "inProgress" || value == "Finished")
                {
                    this._state = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public void CompleteMission()
        {
            this.State = "Finished";
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
    }
}