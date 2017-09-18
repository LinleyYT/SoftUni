using _11.InfernoInfinity.Models.Classes;
using _11.InfernoInfinity.Models.Enums;
using _11.InfernoInfinity.Models.Interfaces;
using System;

namespace _11.InfernoInfinity.Factories
{
    public class WeaponFactory
    {
        public IWeapon CreateWeapon(string[] strings)
        {
            var weaponArgs = strings[0].Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var weaponName = strings[1];
            var rarity = (Rarity) Enum.Parse(typeof(Rarity), weaponArgs[0]);
            var type = weaponArgs[1];

            switch (type)
            {
                case "Axe":
                    return new Axe(weaponName, rarity);

                case "Sword":
                    return new Sword(weaponName, rarity);

                case "Knife":
                    return new Knife(weaponName, rarity);

                default:
                    return null;
            }
        }
    }
}