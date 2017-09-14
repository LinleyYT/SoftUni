using System;
using System.Collections;

public class RandomList : ArrayList
{
    private Random rnd;
    private ArrayList list;

    public RandomList()
    {
        this.rnd = new Random();
    }

    public object RandomString()
    {
        int element = rnd.Next(0, list.Count - 1);
        string str = list[element].ToString();
        list.Remove(str);
        return str;
    }
}