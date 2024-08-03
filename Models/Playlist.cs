using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReatMusic.Models
{
    public class Playlist
    {
        private string name;
        private List<Track> tracks;

        public Playlist(string name)
        {
            this.name = name;
            this.tracks = new List<Track>();
        }

        public string Name { get => name; set => name = value; }
        public List<Track> Tracks { get => tracks; }

        /*public bool AddTrackToPlaylist(Track track)
        {
            // Implement track addition logic
            // Return true if successful, false otherwise
        }

        public bool RemoveTrackFromPlaylist(Track track)
        {
            // Implement track removal logic
            // Return true if successful, false otherwise
        }

        public void RenamePlaylist(string newName)
        {
            name = newName;
        }

        // Additional methods
        public int GetTrackCount() => tracks.Count;
        public TimeSpan GetTotalDuration()
        {
            // Calculate total duration of tracks
        }*/
    }

}
