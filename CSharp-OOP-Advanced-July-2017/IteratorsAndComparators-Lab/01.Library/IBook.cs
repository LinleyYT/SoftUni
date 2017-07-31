using System.Collections.Generic;

namespace _01.Library
{
    public interface IBook
    {
        string Title { get; }
        int Year { get; }
        IReadOnlyList<string> Authors { get; }
    }
}