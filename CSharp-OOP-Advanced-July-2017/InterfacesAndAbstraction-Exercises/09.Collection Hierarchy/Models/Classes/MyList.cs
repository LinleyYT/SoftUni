using _09.Collection_Hierarchy.Models.Interfaces;

namespace _09.Collection_Hierarchy.Models.Classes
{
    public class MyList : AddAtBeginningCollection, IMyList
    {
        public MyList()
        {
            this.Used = this.StringCollectionList.Count;
        }
        public int Used { get; set; }   

        public string RemoveFirstElement()
        {
            var stringToBeRemoved = this.StringCollectionList[0];
            this.StringCollectionList.RemoveAt(0);
            return stringToBeRemoved;
        }
    }
}