using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HierarchicalInheritance
{
    public class HierarchicalInheritance
    {
        public static void Main()
        {
            var dog = new Dog();
            dog.Eat();
            dog.Bark();

            var cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}
