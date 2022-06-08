using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZMusicEntites.Models
{
    public class LikeMusic
    {
        public int Id { get; set; }
        public int User_id { get; set; }
        public int Music_id { get; set; }

        public virtual User User { get; set; }
        public virtual Music Music { get; set; }

    }
}
