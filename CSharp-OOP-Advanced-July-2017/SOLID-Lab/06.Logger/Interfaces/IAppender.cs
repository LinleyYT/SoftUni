namespace _06.Logger.Interfaces
{
    public interface IAppender
    {
        ILayout Layout { get; }

        void Append(string timeStamp, string reportLevel, string message);
    }
}