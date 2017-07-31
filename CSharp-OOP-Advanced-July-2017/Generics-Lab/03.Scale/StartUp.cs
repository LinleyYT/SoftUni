using System;

public class StartUp
{
    public static void Main()
    {
        var scale = new Scale<int>(3, 2);

        Console.WriteLine(scale.GetHavier());
    }
}

