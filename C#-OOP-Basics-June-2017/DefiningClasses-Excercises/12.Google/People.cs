using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Google
{
    public class People
    {
        public string Name { get; set; }
        public Company Company { get; set; }
        public Car Car { get; set; }

        private List<Parents> parents = new List<Parents>();

        public List<Parents> Parents
        {
            get { return this.parents; }
            set { this.parents = value; }
        }

        private List<Children> children = new List<Children>();

        public List<Children> Children
        {
            get { return this.children; }
            set { this.children = value; }
        }
        
        private List<Pokemon> pokemons = new List<Pokemon>();

        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
            set { this.pokemons = value; }
        }


    }
}
