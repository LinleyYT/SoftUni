using RecyclingStation.BusinessLayer.Contracts.IO;
using System;
using System.Text;

namespace RecyclingStation.BusinessLayer.Core.IO
{
    public class ConsoleWriter : IWriter
    {
        private StringBuilder outputGatherer;

        public ConsoleWriter()
            : this(new StringBuilder())
        {
        }

        public ConsoleWriter(StringBuilder outputGatherer)
        {
            this.OutputGatherer = outputGatherer;
        }

        public StringBuilder OutputGatherer
        {
            get { return this.outputGatherer; }
            private set { this.outputGatherer = value; }
        }

        public void GatherOutput(string output)
        {
            this.OutputGatherer.AppendLine(output);
        }

        public void WriteGatheredOutput()
        {
            Console.Write(this.OutputGatherer);
        }
    }
}