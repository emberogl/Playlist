namespace Playlist.View
{
    /// <summary>
    /// Writes every playlist and its content to console
    /// </summary>
    public class Display
    {
        public static void Playlist(params Model.Playlist[] playlists)
        {
            Console.Title = "Playlists";
            foreach (Model.Playlist playlist in playlists)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Playlist: {playlist.GetName()}");
                Console.WriteLine("----------------------------------------");
                Console.ForegroundColor = ConsoleColor.Gray;
                foreach (var track in playlist.GetTracks())
                {
                    Console.WriteLine($"Title: {track.GetTrackName()}");
                    Console.WriteLine($"Artist: {track.GetTrackArtist()}");
                    Console.WriteLine($"Length: {track.GetTrackLength()}\n");
                }
            }
            Console.ReadKey();
        }
    }
}