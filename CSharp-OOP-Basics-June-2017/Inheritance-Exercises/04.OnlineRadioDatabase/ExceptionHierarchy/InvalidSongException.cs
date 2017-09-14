using System;

namespace _04.OnlineRadioDatabase.ExceptionHierarchy
{
    public class InvalidSongException : Exception
    {
        public override string Message => "Invalid song.";
    }
}