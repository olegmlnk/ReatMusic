using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReatMusic.Models
{
    class Album
    {
        public string Name { get; set; }
        public List<Track> Tracks { get; set; }
        public Artist Artist { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Album()
        {
            Tracks = new List<Track>();
        }

        public void AddTrack(Track track)
        {
            Tracks.Add(track);
        }

        public void RemoveTrack(Track track)
        {
            Tracks.Remove(track);
        }
    }
}
