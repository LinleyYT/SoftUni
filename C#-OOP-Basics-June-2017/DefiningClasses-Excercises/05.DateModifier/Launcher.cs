using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Launcher
{
    public static void Main()
    {
        string dateOne = Console.ReadLine().Trim();
        string dateTwo = Console.ReadLine().Trim();

        var dateModifier = new DateModifier();

        var difference = dateModifier.DateDifference(dateOne, dateTwo);

        Console.WriteLine(difference);
    }
}

