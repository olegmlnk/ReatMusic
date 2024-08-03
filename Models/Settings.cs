using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReatMusic.Models
{
    class Settings
    {
        private int volume;
        private bool shuffle;
        private bool repeat;
        private string theme;

        public Settings(int volume, bool shuffle, bool repeat, string theme)
        {
            this.volume = volume;
            this.shuffle = shuffle;
            this.repeat = repeat;
            this.theme = theme;
        }

        public int Volume { get => volume; set => volume = value; }
        public bool Shuffle {  get => shuffle; set => shuffle = value; }
        public bool Repeat { get => repeat; set => repeat = value; }
        public string Theme { get => theme; set => theme = value; }

        public void ChangeVolume(int newVolume) { }
        
        public void ToggleShuffle() { }

        public void ToggleRepeat() { }

        public void ChangeTheme(string newTheme) { }
    }
}
