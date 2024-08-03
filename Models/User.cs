using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReatMusic.Models
{
    public class User
    {
        private string username;
        private string hashedPassword;
        private string email;
        private List<Playlist> playlists;

        public User(string username, string hashedPassword, string email)
        {
            this.username = username;
            this.hashedPassword = hashedPassword;
            this.email = email;
            this.playlists = new List<Playlist>();
        }

        public string Username { get => username; set => username = value; }
        public string HashedPassword { get => hashedPassword; } // Read-only for security
        public string Email { get => email; set => email = value; }
        public List<Playlist> Playlists { get => playlists; }

       /* public bool Login(string username, string password)
        {
            // Implement login logic with password verification
            // Return true if successful, false otherwise
        }

        public void Logout()
        {
            // Implement logout logic
        }

        public bool Register(string username, string hashedPassword, string email)
        {
            // Implement registration logic with validation
            // Return true if successful, false otherwise
        }

        public bool CreatePlaylist(Playlist playlist)
        {
            // Implement playlist creation logic
            // Return true if successful, false otherwise
        }

        public bool RemovePlaylist(Playlist playlist)
        {
            // Implement playlist removal logic
            // Return true if successful, false otherwise
        }*/
    }

}
