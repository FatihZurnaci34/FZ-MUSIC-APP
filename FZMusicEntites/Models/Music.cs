using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZMusicEntites.Models
{
    public class Music
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Category_id { get; set; }
        

        public virtual Category Category { get; set; }
        public int Artist_id { get; set; }
        
        public virtual Artist Artist { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        
        public virtual ICollection<PlayListMusic> PlayListMusics { get; set; }
        public virtual ICollection<LikeMusic> LikeMusics { get; set; }
        
    }
}
