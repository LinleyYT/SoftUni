using _06.Logger.Entities.Appenders;
using _06.Logger.Entities.Layouts;
using _06.Logger.Interfaces;
using _06.Logger.Entities;

namespace _06.Logger
{
    public class Program
    {
        public static void Main()
        {
            var xmlLayout = new XmlLayout();
            var consoleAppender = new ConsoleAppender(xmlLayout);
            var logger = new Entities.Logger(consoleAppender);

            logger.Fatal("3/31/2015 5:23:54 PM", "mscorlib.dll does not respond");
            logger.Critical("3/31/2015 5:23:54 PM", "No connection string found in App.config");

        }
    }
}
