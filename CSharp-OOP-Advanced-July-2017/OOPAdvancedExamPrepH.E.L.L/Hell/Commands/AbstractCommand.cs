public abstract class AbstractCommand : IExecutable
{
    private string[] data;

    protected AbstractCommand(string[] data)
    {
        this.Data = data;
    }

    protected string[] Data
    {
        get { return this.data; }
        private set { this.data = value; }
    }

    public abstract string Execute();
}