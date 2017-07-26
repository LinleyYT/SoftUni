using System.Collections.Generic;

namespace _08.MilitaryElite.Models.Interfaces
{
    public interface ICommando : ISpecialisedSoldier
    {
        IList<IMission> Missions { get; }
    }
}