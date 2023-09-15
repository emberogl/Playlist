namespace Playlist.Model
{
    /// <summary>
    /// A track class which contains:
    /// track length in seconds
    /// track name
    /// track artist
    /// 
    /// Methods:
    /// get track length as string with m:s format
    /// get track name
    /// get track artist
    /// </summary>
    public class Track
    {
        private int _trackLength;
        private string _trackName;
        private string _trackArtist;

        public Track(int trackLength, string trackName, string trackArtist) 
        {
            _trackLength = trackLength;
            _trackName = trackName;
            _trackArtist = trackArtist;
        }

        public string GetTrackLength()
        {
            int minutes = _trackLength / 60;
            int seconds = _trackLength % 60;
            return $"{minutes}:{seconds:D2}";
        }

        public string GetTrackName()
        {
            return _trackName;
        }

        public string GetTrackArtist()
        {
            return _trackArtist;
        }
    }
}
