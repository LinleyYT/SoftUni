using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.GenericBoxOfString
{
    public class Box<T>
        where T : IComparable<T>
    {
        public Box()
        {
            this.List = new List<T>();
        }

        public IList<T> List { get; private set; }

        public int Compare(T element)
        {
            return this.List.Count(x => x.CompareTo(element) > 0);
        }

        public void Swap(int indexOne, int indexTwo)
        {
            var temp = this.List[indexOne];

            this.List[indexOne] = this.List[indexTwo];
            this.List[indexTwo] = temp;
        }

        public void Add(T element)
        {
            this.List.Add(element);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var item in this.List)
            {
                sb.AppendLine($"{item.GetType().FullName}: {item}");
            }

            return sb.ToString().Trim();
        }
    }
}