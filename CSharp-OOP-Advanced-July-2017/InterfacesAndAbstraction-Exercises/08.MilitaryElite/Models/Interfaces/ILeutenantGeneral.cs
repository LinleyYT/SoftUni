using System.Collections.Generic;

namespace _08.MilitaryElite.Models.Interfaces
{
    public interface ILeutenantGeneral : IPrivate
    {
        IList<ISoldier> Privates { get; }
    }
}