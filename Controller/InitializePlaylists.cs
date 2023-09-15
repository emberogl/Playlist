namespace Playlist.Controller
{
    public class InitializePlaylists
    {
        // Songs to add to a linked-list playlist
        #region Songs
        static List<Model.Track> ColourBassSongs = new List<Model.Track>()
        {
            {new Model.Track(trackLength: 254, trackName: "Intermolecular Lullaby", trackArtist: "Chime") },
            {new Model.Track(trackLength: 301, trackName: "Beyond The Peak", trackArtist: "Chime, Skybreak, DNAKM") },
            {new Model.Track(trackLength: 216, trackName: "Turntide", trackArtist: "Nejvex") },
            {new Model.Track(trackLength: 198, trackName: "Arcadia", trackArtist: "Pixel Terror, Ace Aura") }
        };

        static List<Model.Track> HouseSongs = new List<Model.Track>()
        {
            {new Model.Track(trackLength: 163, trackName: "RUSH", trackArtist: "Curbi") },
            {new Model.Track(trackLength: 155, trackName: "Be With You", trackArtist: "Danny Leax, Mick Mazoo") },
            {new Model.Track(trackLength: 229, trackName: "Divine", trackArtist: "Ember Nebula") },
            {new Model.Track(trackLength: 194, trackName: "Just Dance", trackArtist: "Bad Computer") }
        };
        #endregion Songs

        // Creating the playlists and giving the playlist a name
        Model.Playlist ColourBassPlaylist = new Model.Playlist("Colour Bass", ColourBassSongs);
        Model.Playlist HousePlaylist = new Model.Playlist("House", HouseSongs);

        // Displays playlists to console
        public void DisplayPlaylists()
        {
            View.Display.Playlist(ColourBassPlaylist, HousePlaylist);
        }
    }
}