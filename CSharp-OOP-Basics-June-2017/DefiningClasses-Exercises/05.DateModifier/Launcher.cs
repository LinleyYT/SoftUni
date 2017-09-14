using System;

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