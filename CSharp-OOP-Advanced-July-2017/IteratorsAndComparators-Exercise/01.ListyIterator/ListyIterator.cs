using System;
using System.Collections;
using System.Collections.Generic;

namespace _01.ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        public ListyIterator(IEnumerable<T> list)
        {
            this.List = new List<T>(list);
        }

        public IReadOnlyList<T> List { get; private set; }

        public int CurrentIndex { get; set; }

        public bool Move()
        {
            if (this.HasNext())
            {
                CurrentIndex++;

                return true;
            }
            return false;
        }

        public void Print()
        {
            if (this.List.Count == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }

            Console.WriteLine(this.List[this.CurrentIndex]);
        }

        public bool HasNext()
        {
            return this.CurrentIndex + 1 < this.List.Count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.List.Count; i++)
            {
                yield return this.List[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}