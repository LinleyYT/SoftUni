using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

