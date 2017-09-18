using System;
using System.Linq;

namespace _07.CustomList
{
    public class Sorter
    {
        public static CustomList<T> Sort<T>(CustomList<T> customList)
            where T : IComparable<T>
        {
            var temp = customList.List.OrderBy(x => x);
            return new CustomList<T>(temp);
        }
    }
}