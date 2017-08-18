using System;
using System.Collections.Generic;
using System.Linq;
using _11.InfernoInfinity.Factories;
using _11.InfernoInfinity.Models.Interfaces;

namespace _11.InfernoInfinity.Core
{
    public class CommandInterpreter
    {
        public CommandInterpreter()
        {
            this.Weapons = new List<IWeapon>();
            this.WeaponFactory = new WeaponFactory();
            this.GemFactory = new GemFactory();
        }
        public IList<IWeapon> Weapons { get; private set; }
        public WeaponFactory WeaponFactory { get; private set; }
        public GemFactory GemFactory { get; private set; }  

        public void CreateWeapon(string[] strings)
        {
            var currentWeapon = this.WeaponFactory.CreateWeapon(strings);

            if (currentWeapon == null)
            {
               throw new ArgumentNullException();
            }

            this.Weapons.Add(currentWeapon);
        }

        public void AddToWeapon(string[] strings)
        {
            var weaponName = strings[0];
            var socketIndex = int.Parse(strings[1]);
            var currentGem = GemFactory.CreateGem(strings.LastOrDefault());

            if (currentGem == null)
            {
                throw new ArgumentNullException();
            }

            AddGemToSockets(currentGem, weaponName, socketIndex);
        }

        private void AddGemToSockets(IGem currentGem, string weaponName, int socketIndex)
        {
            if (socketIndex >= this.Weapons.FirstOrDefault(x => x.Name == weaponName).Sockets.Count)
            {
                throw new ArgumentException("Invalid socket index");
            }

            this.Weapons.FirstOrDefault(x => x.Name == weaponName).AddGem(socketIndex, currentGem);
        }

        public void RemoveGem(string[] strings)
        {
            var weaponName = strings[0];
            var gemIndex = int.Parse(strings[1]);

            if (gemIndex >= this.Weapons.FirstOrDefault(x => x.Name == weaponName).Sockets.Count 
                || this.Weapons.FirstOrDefault(x => x.Name == weaponName).Sockets[gemIndex] == null)
            {
                throw new ArgumentException("Invalid index");
            }

            this.Weapons.FirstOrDefault(x => x.Name == weaponName).Sockets[gemIndex] = null;
        }

        public void Print(string weaponName)
        {
            Console.WriteLine(this.Weapons.FirstOrDefault(x => x.Name == weaponName));
        }
    }
}