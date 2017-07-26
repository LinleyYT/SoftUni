using _09.Collection_Hierarchy.Models.Interfaces;

namespace _09.Collection_Hierarchy.Models.Classes
{
    public class AddRemoveCollection : AddAtBeginningCollection, IRemoveLastItem
    {
        public string RemoveLastItem()
        {
            var stringToBeRemoved = this.StringCollectionList[this.StringCollectionList.Count - 1];
            this.StringCollectionList.RemoveAt(this.StringCollectionList.Count - 1);
            return stringToBeRemoved;
        }
    }
}