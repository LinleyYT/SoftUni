using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04.OnlineRadioDatabase.ExceptionHierarchy;

namespace _04.OnlineRadioDatabase
{
    public class Song
    {
        public Song(string artistName, string songName, string minutes, string seconds)
        {
            this.ArtistName = artistName;
            this.SongName = songName;

            if (String.IsNullOrWhiteSpace(minutes) || String.IsNullOrWhiteSpace(seconds))
            {
                throw new InvalidSongLengthException();
            }

            if (int.Parse(minutes) < 0 || int.Parse(minutes) > 14)
            {
                throw new InvalidSongMinutesException();
            }
            else
            {
                this.songMinutes = minutes;
            }

            if (int.Parse(seconds) < 0 || int.Parse(seconds) > 59)
            {
                throw new InvalidSongSecondsException();
            }
            else
            {
                this.songSeconds = seconds;
            }

            this.SongLength = GetSongLenght();
        }

        private string artistName;

        public string ArtistName
        {
            get { return this.artistName; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException();
                }

                this.artistName = value;
            }
        }

        private string songName;

        public string SongName
        {
            get { return this.songName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidSongNameException();
                }

                this.songName = value;
            }
        }

        private TimeSpan songLength;

        public TimeSpan SongLength
        {
            get { return this.songLength; }
            set { this.songLength = value; }
        }

        private string songMinutes;
        private string songSeconds;

        private TimeSpan GetSongLenght()
        {
            var songLength = new TimeSpan();

            songLength += TimeSpan.FromSeconds(double.Parse(this.songSeconds));
            songLength += TimeSpan.FromMinutes(double.Parse(this.songMinutes));

            return songLength;
        }


    }
}
