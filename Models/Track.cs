using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReatMusic.Models
{
    public class Track
    {
        private string title;
        private string artist;
        private string album;
        private string genre;
        private string filePath;
        private readonly TimeSpan duration;

        public Track(string title, string artist, string album, string genre, string filePath, TimeSpan duration)
        {
            this.title = title;
            this.artist = artist;
            this.album = album;
            this.genre = genre;
            this.filePath = filePath;
            this.duration = duration;
        }

        public string Title { get => title; set => title = value; }
        public string Artist { get => artist; set => artist = value; }
        public string Album { get => album; set => album = value; }
        public string Genre { get => genre; set => genre = value; }
        public string FilePath { get => filePath; set => filePath = value; }
        public TimeSpan Duration { get => duration; }

        public void Play() { }
        public void Pause() { }
        public void Stop() { }
    }
}