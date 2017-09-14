using _04.OnlineRadioDatabase.ExceptionHierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.OnlineRadioDatabase
{
    public class OnlineRadioDatabase
    {
        public static void Main()
        {
            var songDb = new List<Song>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                try
                {
                    var songArgs = Console.ReadLine()
                        .Trim()
                        .Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => x.Trim())
                        .ToArray();

                    var artist = songArgs[0];
                    var songName = songArgs[1];

                    var match = Regex.Match(songArgs[2], "^([0-9]+):([0-9]+)$");
                    if (!match.Success)
                    {
                        throw new InvalidSongLengthException();
                    }
                    var songLengthArgs = songArgs[2].Split(':');
                    var minutes = songLengthArgs[0];
                    var seconds = songLengthArgs[1];

                    var song = new Song(artist, songName, minutes, seconds);
                    songDb.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            var totalSongTime = new TimeSpan(songDb.Sum(x => x.SongLength.Ticks));
            Console.WriteLine($"Songs added: {songDb.Count}");
            Console.WriteLine(
                $"Playlist length: {totalSongTime.Hours}h {totalSongTime.Minutes}m {totalSongTime.Seconds}s");
        }
    }
}