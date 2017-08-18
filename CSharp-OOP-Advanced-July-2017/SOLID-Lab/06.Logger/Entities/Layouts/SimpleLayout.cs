using _06.Logger.Interfaces;

namespace _06.Logger.Entities.Layouts
{
    public class SimpleLayout : ILayout
    {
        public string FormatMessage(string timeStamp, string reportLevel, string message)
        {
            return $"{timeStamp} - {reportLevel} - {message}";
        }
    }
}