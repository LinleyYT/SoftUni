﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Google
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public Pokemon(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }
    }
}
