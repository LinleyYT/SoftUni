using System;
using System.Collections;
using System.Collections.Generic;

namespace _04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        public Lake(List<int> ints)
        {
            this.Ints = ints;
        }

        public List<int> Ints { get; set; }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.Ints.Count; i += 2)
            {
                yield return this.Ints[i];
            }

            var lastOddIndex = this.Ints.Count - 1;

            if (lastOddIndex % 2 == 0)
            {
                lastOddIndex--;
            }

            for (int i = lastOddIndex; i > 0; i -= 2)
            {
                yield return this.Ints[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
        
    }
}