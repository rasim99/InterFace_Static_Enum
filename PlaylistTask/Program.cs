namespace PlaylistTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Song song=new Song("Shape of you","Edd Shreen",MusicGenre.Pop,new TimeSpan(0,3,30));
            Playlist playlist = new Playlist();
            playlist.AddSong(song);
            playlist.GetAllSongsByGenre(MusicGenre.Pop);
            playlist.GetAllSongsByGenre(MusicGenre.Rock);
        }
    }
}
