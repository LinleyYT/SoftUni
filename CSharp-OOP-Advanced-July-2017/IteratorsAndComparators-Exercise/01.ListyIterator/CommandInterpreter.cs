using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.ListyIterator
{
    public class CommandInterpreter
    {
        public void Run()
        {
            ListyIterator<string> listyIterator = null;

            var listyIteratorArgs = Console.ReadLine().Split();

            if (listyIteratorArgs.Length == 1)
            {
                listyIterator = new ListyIterator<string>(new List<string>());
            }
            else
            {
                listyIterator = new ListyIterator<string>(listyIteratorArgs.Skip(1));
            }

            var input = String.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                try
                {
                    var inputArgs = input.Split();
                    var command = inputArgs[0];

                    switch (command)
                    {
                        case "Move":
                            Console.WriteLine(listyIterator.Move());
                            break;
                        case "Print":
                            listyIterator.Print();
                            break;
                        case "HasNext":
                            Console.WriteLine(listyIterator.HasNext());
                            break;
                        case "PrintAll":
                            var sb = new StringBuilder();

                            foreach (var item in listyIterator)
                            {
                                sb.Append($"{item} ");
                            }

                            Console.WriteLine(sb.ToString().Trim());
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}