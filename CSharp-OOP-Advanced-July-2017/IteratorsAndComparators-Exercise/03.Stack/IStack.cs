using System.Collections.Generic;

namespace _03.Stack
{
    public interface IStack<T>
    {
        List<T> List { get; }

        void Push(params T[] stackArgs);

        void Pop();
    }
}