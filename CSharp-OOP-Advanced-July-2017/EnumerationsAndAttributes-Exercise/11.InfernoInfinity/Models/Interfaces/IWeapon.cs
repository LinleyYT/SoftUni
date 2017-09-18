using _11.InfernoInfinity.Models.Enums;
using System.Collections;

namespace _11.InfernoInfinity.Models.Interfaces
{
    public interface IWeapon
    {
        IList Sockets { get; }
        Rarity Rarity { get; }
        string Name { get; }

        int GetTotalMinDamage();

        int GetTotalMaxDamage();

        void AddGem(int index, IGem gem);
    }
}