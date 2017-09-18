using System;
using System.Linq;

namespace _03.Stack
{
    public class CommandInterpreter
    {
        public void Run()
        {
            var input = String.Empty;
            var stack = new Stack<int>();

            while ((input = Console.ReadLine()) != "END")
            {
                var inputArgs = input.Split();
                var command = inputArgs[0];

                switch (command)
                {
                    case "Push":
                        var stackArgs = input.Substring(command.Length + 1)
                            .Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                        stack.Push(stackArgs);
                        break;

                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                }
            }

            var foreachCount = 0;

            while (foreachCount < 2)
            {
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
                foreachCount++;
            }
        }
    }
}