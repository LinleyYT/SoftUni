using System;

public class StartUp
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split();
        var urls = Console.ReadLine().Split();
        var smartphone = new Smartphone();

        foreach (var number in numbers)
        {
            try
            {
                Console.WriteLine(smartphone.Call(number));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        foreach (var url in urls)
        {
            try
            {
                Console.WriteLine(smartphone.Browse(url));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}