public interface IManager
{
    IExecutable InterpretCommand(string[] data, string commandName);
}
