namespace _04.OnlineRadioDatabase.ExceptionHierarchy
{
    public class InvalidArtistNameException : InvalidSongException
    {
        public override string Message => "Artist name should be between 3 and 20 symbols.";
    }
}