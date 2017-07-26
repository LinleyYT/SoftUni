using System.Collections.Generic;

namespace _08.MilitaryElite.Models.Interfaces
{
    public interface IEngineer : ISpecialisedSoldier
    {
        IList<IRepair> Repairs { get; }
    }
}