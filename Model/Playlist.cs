namespace Playlist.Model
{
    /// <summary>
    /// The playlist class that will be created to hold tracks
    /// </summary>
    public class Playlist
    {
        private string _name;
        private LinkedList<Track> _tracks = new LinkedList<Track>();

        public Playlist(string name, List<Track> tracks)
        {
            _name = name;

            foreach (Track track in tracks)
            {
                _tracks.AddLast(track);
            }
        }

        public string GetName()
        {
            return _name;
        }

        public LinkedList<Track> GetTracks()
        {
            return _tracks;
        }
    }
}