using System;
using System.IO;
using System.Linq;
using System.Text;

namespace _06.Logger.Entities
{
    public class LogFile
    {
        private const string DefaultFileName = "log.txt";

        private StringBuilder stringBuilder;

        public LogFile()
        {
            this.stringBuilder = new StringBuilder();
        }

        public int Size { get; private set; }

        public void Write(string formattedMsg)
        {
            this.stringBuilder.AppendLine(formattedMsg);
            File.AppendAllText(DefaultFileName, formattedMsg + Environment.NewLine);
            this.Size += GetSumOfLetter(formattedMsg);
        }

        private int GetSumOfLetter(string formattedMsg)
        {
            return formattedMsg.Where(char.IsLetter)
                .Sum(c => c);
        }
    }
}