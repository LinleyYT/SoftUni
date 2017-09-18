using _06.Logger.Interfaces;
using System.Text;

namespace _06.Logger.Entities.Layouts
{
    public class XmlLayout : ILayout
    {
        public string FormatMessage(string timeStamp, string reportLevel, string message)
        {
            var sb = new StringBuilder();

            return sb.AppendLine("<log>")
                .AppendLine($"  <date>{timeStamp}</date>")
                .AppendLine($"  <level>{reportLevel}</level>")
                .AppendLine($"  <message>{message}</message>")
                .AppendLine("</log>")
                .ToString();
        }
    }
}