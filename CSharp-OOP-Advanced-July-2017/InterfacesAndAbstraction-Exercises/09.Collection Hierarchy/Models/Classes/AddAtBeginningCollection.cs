using System;
using System.Collections.Generic;
using _09.Collection_Hierarchy.Models.Interfaces;

namespace _09.Collection_Hierarchy.Models.Classes
{
    public abstract class AddAtBeginningCollection : IAddAtBeginning, IStringCollection
    {
        protected AddAtBeginningCollection()
        {
            this.StringCollectionList = new List<string>();
        }
        
        public List<string> StringCollectionList { get; private set; }

        public int AddAtBeginning(string stringToAdd)
        {
            if (this.StringCollectionList.Count < 100)
            {
                this.StringCollectionList.Insert(0, stringToAdd);
                return 0;
            }
            throw new ArgumentException();
        }
    }
}