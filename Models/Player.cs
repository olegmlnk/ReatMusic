using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReatMusic.Models
{
    class Player
    {
        public Track CurrentTrack { get; set; }
        public TimeSpan CurrentPosition { get; set; }
        public bool IsPlaying { get; set; }

        public Player()
        {
            IsPlaying = false;
        }

        public void PlayTrack(Track track)
        {
            CurrentTrack = track;
            CurrentPosition = TimeSpan.Zero;
            IsPlaying = true;
            // Start playback logic here
        }

        public void Pause()
        {
            if (IsPlaying)
            {
                IsPlaying = false;
                // Pause playback logic here
            }
        }

        public void Stop()
        {
            IsPlaying = false;
            CurrentPosition = TimeSpan.Zero;
            // Stop playback logic here
        }

        public void Seek(TimeSpan position)
        {
            if (IsPlaying)
            {
                CurrentPosition = position;
                // Seek to the specified position in the track
            }
        }

        public void NextTrack()
        {
            // Logic to determine the next track based on playlist or other criteria
            // Play the next track using PlayTrack method
        }

        public void PreviousTrack()
        {
            // Logic to determine the previous track based on playlist or other criteria
            // Play the previous track using PlayTrack method
        }
    }
}
