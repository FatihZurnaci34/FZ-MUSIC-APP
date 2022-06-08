using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZMusicEntites.Models
{
   public class PlayListMusic
    {
        public int PlayListMusicId { get; set; }
        public int PlaylistId { get; set; }
        public Playlist Playlist { get; set; }
        public int MusicId { get; set; }
        public Music Music { get; set; }
    }
}
