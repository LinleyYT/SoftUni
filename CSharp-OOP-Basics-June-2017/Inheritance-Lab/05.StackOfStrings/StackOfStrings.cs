using System.Collections.Generic;

public class StackOfStrings : Stack<string>
{
    private List<string> data;

    public StackOfStrings()
    {
        data = new List<string>();
    }

    public void Push(string item)
    {
    }

    public string Pop()
    {
        return "";
    }

    public string Peek()
    {
        return "";
    }

    public bool IsEmpty()
    {
        return true;
    }
}