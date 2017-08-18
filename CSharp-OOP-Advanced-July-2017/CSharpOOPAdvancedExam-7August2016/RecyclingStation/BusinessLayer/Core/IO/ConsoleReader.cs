using System;
using RecyclingStation.BusinessLayer.Contracts.IO;

namespace RecyclingStation.BusinessLayer.Core.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}