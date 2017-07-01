﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PokemonTrainer
{
    public class Trainer
    {
        public string Name { get; set; }
        private List<Pokemon> pokemons = new List<Pokemon>();

        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
            set { this.pokemons = value; }
        }

        public int Badges { get; set; }

        public Trainer(string name, List<Pokemon> pokemons)
        {
            this.Name = name;
            this.pokemons = pokemons;
        }

        
    }
}
