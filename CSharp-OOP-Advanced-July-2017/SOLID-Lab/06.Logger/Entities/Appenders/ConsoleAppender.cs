using System;
using _06.Logger.Interfaces;

namespace _06.Logger.Entities.Appenders
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ILayout Layout { get; }

        public void Append(string timeStamp, string reportLevel, string message)
        {
            string formattedMsg = this.Layout.FormatMessage(timeStamp, reportLevel, message);
            Console.WriteLine(formattedMsg);
        }
    }
}