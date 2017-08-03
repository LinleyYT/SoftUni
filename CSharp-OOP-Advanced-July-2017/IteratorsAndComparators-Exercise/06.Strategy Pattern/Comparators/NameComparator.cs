using System.Collections.Generic;

namespace _06.Strategy_Pattern.Comparators
{
    public class NameComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Name.Length.CompareTo(y.Name.Length) != 0)
            {
                return x.Name.Length.CompareTo(y.Name.Length);
            }
            if (x.Name.ToLower()[0].CompareTo(y.Name.ToLower()[0]) != 0)
            {
                return x.Name.ToLower()[0].CompareTo(y.Name.ToLower()[0]);
            }
            return 0;
        }
    }
}