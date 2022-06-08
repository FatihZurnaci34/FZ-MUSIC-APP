using FZMusicEntites.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZMusicEntites.Maps
{
    public class LikeMusicMap : EntityTypeConfiguration<LikeMusic>
    {
        public LikeMusicMap()
        {
            this.ToTable("tblLikeMusic");
            this.Property(p => p.Id).HasColumnType("int");
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.HasRequired(p => p.User).WithMany(p => p.LikeMusics).HasForeignKey(p => p.User_id);
            this.HasRequired(p => p.Music).WithMany(p => p.LikeMusics).HasForeignKey(p => p.Music_id);
        }
    }
}