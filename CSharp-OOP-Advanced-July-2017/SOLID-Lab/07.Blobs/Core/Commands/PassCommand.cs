using System;

namespace _02.Blobs.Core.Commands
{
    public class PassCommand : Command
    {
        public PassCommand(string[] data) : base(data)
        {
        }

        public override string Execute()
        {
            return String.Empty;
        }
    }
}