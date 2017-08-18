using _06.Logger.Interfaces;

namespace _06.Logger.Entities.Appenders
{
    public class FileAppender : IAppender
    {
        public FileAppender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ILayout Layout { get; }

        public LogFile File { get; set; }

        public void Append(string timeStamp, string reportLevel, string message)
        {
            string formattedMsg = this.Layout.FormatMessage(timeStamp, reportLevel, message);
            this.File.Write(formattedMsg);
        }
    }
}