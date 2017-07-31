using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _07.CustomList
{
    public class CustomList<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        public CustomList(IEnumerable<T> collection)
        {
            this.List = new List<T>(collection);
        }
        public IList<T> List { get; private set; }

        public void Add(T element)
        {
            this.List.Add(element);
        }

        public void Remove(int index)
        {
            this.List.RemoveAt(index);
        }

        public void Contains(T element)
        {
            Console.WriteLine(this.List.Contains(element) ? "True" : "False");
        }

        public void Swap(int indexOne, int indexTwo)
        {
            var temp = this.List[indexOne];

            this.List[indexOne] = this.List[indexTwo];
            this.List[indexTwo] = temp;
        }

        public void Greater(T element)
        {
            Console.WriteLine(this.List.Count(x => x.CompareTo(element) > 0));
        }

        public void Max()
        {
            Console.WriteLine(this.List.Max());
        }

        public void Min()
        {
            Console.WriteLine(this.List.Min());
        }

        public void Print()
        {
            foreach (var item in this.List)
            {
                Console.WriteLine(item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.List.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}