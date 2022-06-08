using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZMusicEntites.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime DogumTarihi { get; set; }

        public virtual ICollection<Playlist> Playlists { get; set; }
        public virtual ICollection<LikeMusic> LikeMusics { get; set; }


    }
}
