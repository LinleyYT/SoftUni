namespace _04.OnlineRadioDatabase.ExceptionHierarchy
{
    public class InvalidSongSecondsException : InvalidSongLengthException
    {
        public override string Message => "Song seconds should be between 0 and 59.";
    }
}