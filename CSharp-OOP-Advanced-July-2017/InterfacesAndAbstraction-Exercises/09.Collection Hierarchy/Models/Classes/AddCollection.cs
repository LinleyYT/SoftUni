using System;
using System.Collections.Generic;
using _09.Collection_Hierarchy.Models.Interfaces;

namespace _09.Collection_Hierarchy.Models.Classes
{
    public class AddCollection : IAddCollection, IStringCollection
    {
        public AddCollection()
        {
            this.StringCollectionList = new List<string>();
        }

        public List<string> StringCollectionList { get; private set; }

        public int Add(string stringToAdd)
        {
            if (this.StringCollectionList.Count < 100)
            {
                this.StringCollectionList.Add(stringToAdd);
                return this.StringCollectionList.Count - 1;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}