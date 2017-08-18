using _06.Logger.Interfaces;

namespace _06.Logger.Entities
{
    public class Logger : ILogger
    {
        private IAppender[] appenders;

        public Logger(params IAppender[] appender)
        {
            this.appenders = appender;
        }

        private void Log(string timeStamp, string reportLevel, string message)
        {
            foreach (var appender in this.appenders)
            {
                appender.Append(timeStamp, reportLevel, message);
            }
        }

        public void Error(string timeStamp, string message)
        {
            this.Log(timeStamp, "Error", message);
        }

        public void Info(string timeStamp, string message)
        {
            this.Log(timeStamp, "Info", message);
        }

        public void Fatal(string timeStamp, string message)
        {
            this.Log(timeStamp, "Fatal", message);
        }

        public void Critical(string timeStamp, string message)
        {
            this.Log(timeStamp, "Critical", message);
        }
    }
}