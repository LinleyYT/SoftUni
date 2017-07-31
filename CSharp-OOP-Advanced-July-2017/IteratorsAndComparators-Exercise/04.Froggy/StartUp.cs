using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Froggy
{
    public class StartUp
    {
        public static void Main()
        {
            var inputArgs = Console.ReadLine()
                .Trim()
                .Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var lake = new Lake(inputArgs);
            var resultList = new List<int>();

            foreach (var stone in lake)
            {
                resultList.Add(stone);
            }

            Console.WriteLine(String.Join(", ", resultList));
        }
    }
}
