using RecyclingStation.BusinessLayer.Contracts.IO;
using System;

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