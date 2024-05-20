using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistTask
{
    internal class Playlist
    {
        private Song[]songs;
        public Song[] Songs { get=>songs; }
        public Playlist()
        {
            songs = new Song[0];
        }
        public void AddSong(Song song)
        {
             Array.Resize(ref songs, songs.Length+1);
            songs[songs.Length-1] = song;
        }

        public void  GetAllSongsByGenre(MusicGenre genre)
        {
            bool songFound = false;

            foreach (Song song in songs)
            {
                if (song.Genre==genre)
                {
                   song.GetDetails();   
                    songFound = true;
                }
            }
            if (!songFound)
            {
                Console.WriteLine($"dont have song with the {genre}");
            }
        }
    }
}
