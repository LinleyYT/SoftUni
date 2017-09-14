namespace _04.OnlineRadioDatabase.ExceptionHierarchy
{
    public class InvalidSongLengthException : InvalidSongException
    {
        public override string Message => "Invalid song length.";
    }
}