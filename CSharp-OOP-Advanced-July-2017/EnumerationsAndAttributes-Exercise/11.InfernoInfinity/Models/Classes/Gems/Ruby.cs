﻿using _11.InfernoInfinity.Models.Enums;
using _11.InfernoInfinity.Models.Interfaces;

namespace _11.InfernoInfinity.Models.Classes.Gems
{
    public class Ruby : IGem
    {
        private const int Strength = 7;
        private const int Agility = 2;
        private const int Vitality = 5;

        public Ruby(Clarity clarity)
        {
            this.Clarity = clarity;
        }

        public Clarity Clarity { get; private set; }

        public int GetTotalStrength()
        {
            return Strength + (int) this.Clarity;
        }

        public int GetTotalAgility()
        {
            return Agility + (int) this.Clarity;
        }

        public int GetTotalVitality()
        {
            return Vitality + (int) this.Clarity;
        }
    }
}