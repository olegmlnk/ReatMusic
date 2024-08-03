using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReatMusic.Models
{
    class Library
    {
        List<Track> Tracks;
        List<Album> Albums;
        List<Artist> Atrists;

       /* public Library()
        {
            this.tracks = new List<Track>();
            this.albums = new List<Album>();
            this.atrists = new List<Artist>();
        }

        public List<Album> Albums { get => albums; }
        public List<Track> Tracks { get => tracks; }
        public List<Artist> Artists { get => artists; }

        public void AddTrack(Track track) { }
        
        public void RemoveTrack(Track track) { }
        
        public List<Track> SearchTracks(string query) { }
        
        public List<Album> SearchAlbums(string query) { }
        
        public List<Artist> SearchArtists(string query) { }
*/

        //методи, які зробимо потім
        public void AddAlbumToLibrary(Album album) { }
        public void RemoveAlbumFromLibrary(Album album) { }
        public void AddArtistToLibrary(Artist artist) { }
        public void RemoveArtistFromLibrary(Artist artist) { }
    }
}
