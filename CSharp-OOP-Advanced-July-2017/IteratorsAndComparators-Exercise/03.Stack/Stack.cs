using System;
using System.Collections;
using System.Collections.Generic;

namespace _03.Stack
{
    public class Stack<T> : IStack<T>, IEnumerable<T>
    {
        public Stack()
        {
            this.List = new List<T>();
        }

        public List<T> List { get; private set; }

        public void Push(params T[] stackArgs)
        {
            this.List.AddRange(stackArgs);
        }

        public void Pop()
        {
            if (this.List.Count < 1)
            {
                throw new ArgumentException("No elements");
            }
            this.List.RemoveAt(this.List.Count - 1);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.List.Count - 1; i >= 0; i--)
            {
                yield return this.List[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}