using System.Collections.Generic;

namespace _06.Strategy_Pattern.Comparators
{
    public class AgeComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Age.CompareTo(y.Age) != 0)
            {
                return x.Age.CompareTo(y.Age);
            }
            return 0;
        }
    }
}