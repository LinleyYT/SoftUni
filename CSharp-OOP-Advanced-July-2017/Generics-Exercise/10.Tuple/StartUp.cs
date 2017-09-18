using System;

namespace _10.Tuple
{
    public class StartUp
    {
        public static void Main()
        {
            var inputOne = Console.ReadLine().Split();
            var fullName = $"{inputOne[0]} {inputOne[1]}";
            var address = inputOne[2];
            var town = inputOne[3];

            Console.WriteLine(new Tuple<string, string, string>(fullName, address, town));

            var inputTwo = Console.ReadLine().Split();
            var name = inputTwo[0];
            var beer = int.Parse(inputTwo[1]);
            var drunk = inputTwo[2];
            bool isDrunk = drunk == "drunk";

            Console.WriteLine(new Tuple<string, int, bool>(name, beer, isDrunk));

            var inputThree = Console.ReadLine().Split();
            var nameThree = inputThree[0];
            var accountBalance = double.Parse(inputThree[1]);
            var bankName = inputThree[2];

            Console.WriteLine(new Tuple<string, double, string>(nameThree, accountBalance, bankName));
        }
    }
}