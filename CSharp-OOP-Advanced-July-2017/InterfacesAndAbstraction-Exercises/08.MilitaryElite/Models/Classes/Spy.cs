using System.Text;
using _08.MilitaryElite.Models.Interfaces;

namespace _08.MilitaryElite.Models.Classes
{
    public class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstName, string lastName, int codeNumber) 
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        private int _codeNumber;

        public int CodeNumber
        {
            get { return _codeNumber; }
            set
            {
                if (value > 0)
                {
                    _codeNumber = value;
                }
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id}");
            sb.AppendLine($"Code Number: {this.CodeNumber}");

            return sb.ToString().Trim();
        }
    }
}