namespace _02.Blobs.Interfaces
{
    public interface ICommandInterpretable
    {
        IExecutable InterpretCommand(string[] data, string commandName);
    }
}