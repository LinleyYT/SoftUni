using System.Collections.Generic;
using System.Linq;

public class Box<T>
{
    public Box()
    {
        this.BoxContentList = new List<T>();
    }

    public IList<T> BoxContentList { get; private set; }
    public int Count => this.BoxContentList.Count;

    public void Add(T element)
    {
        this.BoxContentList.Add(element);
    }

    public T Remove()
    {
        var elementToReturn = this.BoxContentList.LastOrDefault();
        this.BoxContentList.RemoveAt(this.BoxContentList.Count - 1);

        return elementToReturn;
    }
}