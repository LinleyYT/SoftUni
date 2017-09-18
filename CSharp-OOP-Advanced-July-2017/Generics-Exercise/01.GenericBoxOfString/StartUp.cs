using System;

namespace _01.GenericBoxOfString
{
    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var box = new Box<double>();

            for (int i = 0; i < n; i++)
            {
                var input = double.Parse(Console.ReadLine());

                box.Add(input);
            }

            var compareToElement = double.Parse(Console.ReadLine());

            Console.WriteLine(box.Compare(compareToElement));
        }
    }
}