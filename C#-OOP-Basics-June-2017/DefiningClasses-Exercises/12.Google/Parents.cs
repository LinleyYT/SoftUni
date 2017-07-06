using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Google
{
    public class Parents
    {
        public string Name { get; set; }
        public string Birthday { get; set; }

        public Parents(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }
    }
}
