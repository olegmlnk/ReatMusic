using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReatMusic.Models
{
    public class Artist
    {
        private string name;
        private List<Album> albums;
        private List<Track> tracks;

        public Artist(string name)
        {
            this.name = name;
            this.albums = new List<Album>();
            this.tracks = new List<Track>();
        }

       /* public string Name { get => name; set => name = value; }
        public List<Album> Albums { get => albums; }
        public List<Track> Tracks { get => tracks; }

        public bool AddAlbumToArtist(Album album)
        {
            // Implement album addition logic
            // Return true if successful, false otherwise
        }

        public bool RemoveAlbumFromArtist(Album album)
        {
            // Implement album removal logic
            // Return true if successful, false otherwise
        }

        // Additional methods
        public int GetAlbumCount() => albums.Count;
        public int GetTrackCount() => tracks.Count;*/
    }

}
