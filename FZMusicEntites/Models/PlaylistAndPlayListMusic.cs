using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZMusicEntites.Models
{
    public class PlaylistAndPlayListMusic
    {
        public virtual IEnumerable<Playlist> Playlists { get; set; }
        public virtual IEnumerable<PlayListMusic> PlayListMusics { get; set; }
        public virtual IEnumerable<Music> Musics { get; set; }



    }
}
