using _11.InfernoInfinity.Models.Enums;
using _11.InfernoInfinity.Models.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace _11.InfernoInfinity.Models.Classes
{
    public class Knife : IWeapon
    {
        private const int BaseMinDamage = 3;
        private const int BaseMaxDamage = 4;
        private const int SocketCount = 2;

        public Knife(string name, Rarity rarity)
        {
            this.Name = name;
            this.Rarity = rarity;
            this.Sockets = new List<IGem>(new IGem[SocketCount]);
        }

        public string Name { get; private set; }
        public IList Sockets { get; }
        public Rarity Rarity { get; }

        public void AddGem(int index, IGem gem)
        {
            if (index < SocketCount)
            {
                this.Sockets[index] = gem;
            }
        }

        public int GetTotalMinDamage()
        {
            var totalMinDamage = BaseMinDamage * (int) this.Rarity;

            foreach (IGem gem in this.Sockets)
            {
                if (gem == null)
                {
                    continue;
                }
                totalMinDamage += gem.GetTotalStrength() * 2;
                totalMinDamage += gem.GetTotalAgility();
            }

            return totalMinDamage;
        }

        public int GetTotalMaxDamage()
        {
            var totalMaxDamage = BaseMaxDamage * (int) this.Rarity;

            foreach (IGem gem in this.Sockets)
            {
                if (gem == null)
                {
                    continue;
                }
                totalMaxDamage += gem.GetTotalStrength() * 3;
                totalMaxDamage += gem.GetTotalAgility() * 4;
            }

            return totalMaxDamage;
        }

        public override string ToString()
        {
            var totalStrength = 0;
            var totalAgility = 0;
            var totalVitality = 0;

            foreach (IGem gem in this.Sockets)
            {
                if (gem == null)
                {
                    continue;
                }
                totalStrength += gem.GetTotalStrength();
                totalAgility += gem.GetTotalAgility();
                totalVitality += gem.GetTotalVitality();
            }

            return
                $"{this.Name}: {this.GetTotalMinDamage()}-{this.GetTotalMaxDamage()} Damage, +{totalStrength} Strength, +{totalAgility} Agility, +{totalVitality} Vitality";
        }
    }
}