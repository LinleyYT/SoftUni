namespace _04.OnlineRadioDatabase.ExceptionHierarchy
{
    public class InvalidSongMinutesException : InvalidSongLengthException
    {
        public override string Message => "Song minutes should be between 0 and 14.";
    }
}