using FZMusicEntites.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace FZMusicEntites.Maps
{
   public class PlayListMusicMap : EntityTypeConfiguration<PlayListMusic>
    {
        public PlayListMusicMap()
        {
            this.ToTable("PlayListMusic");
            this.Property(p => p.PlayListMusicId).HasColumnType("int");
            this.Property(p => p.PlayListMusicId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.HasRequired(p => p.Playlist).WithMany(p => p.PlayListMusics).HasForeignKey(p => p.PlaylistId);
            this.HasRequired(p => p.Music).WithMany(p => p.PlayListMusics).HasForeignKey(p => p.MusicId);
        }
    }
}
