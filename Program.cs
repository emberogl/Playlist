namespace Playlist
{
    internal class Program
    {
        /// <summary>
        /// Starts controller that loads songs from a list into a linked-list playlist, and
        /// displays those playlists
        /// </summary>
        static void Main(string[] args)
        {
            Controller.InitializePlaylists initializePlaylists = new Controller.InitializePlaylists();
            initializePlaylists.DisplayPlaylists();
        }
    }
}