using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZMusicEntites.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int User_id { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<PlayListMusic> PlayListMusics { get; set; }
    }
}
