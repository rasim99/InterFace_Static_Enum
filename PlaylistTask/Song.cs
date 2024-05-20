using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistTask
{
    internal class Song
    {
        public Song(string title, string artist, MusicGenre genre, TimeSpan duration)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            Genre = genre;
        }

        public string Title { get; set; }
        public string Artist { get; set; }
        public TimeSpan Duration { get; set; }
        public MusicGenre Genre { get; set; }
        public void GetDetails()
        {
            Console.WriteLine($"Title  {Title} " +
                        $" {Artist} " +
                        $"Duration {Duration}");
        }
    }
}
