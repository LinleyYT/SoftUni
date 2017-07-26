using System;
using System.Linq;

public class Smartphone : IBrowsable, ICallable
{
    public string Browse(string url)
    {
        if (url.Any(x => Char.IsDigit(x)))
        {
            throw new ArgumentException("Invalid URL!");
        }
        return $"Browsing: {url}!";
    }

    public string Call(string number)
    {
        if (number.Any(x => !Char.IsDigit(x)))
        {
            throw new ArgumentException("Invalid number!");
        }
        return $"Calling... {number}";
    }
}