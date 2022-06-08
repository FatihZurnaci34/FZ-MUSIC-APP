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
    public class MusicMap : EntityTypeConfiguration<Music>
    {
        public MusicMap()
        {
            this.ToTable("tblMusic");
            this.Property(p => p.Id).HasColumnType("int");
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Name).HasColumnType("nvarchar").HasMaxLength(100);
            this.Property(p => p.Image).HasColumnType("nvarchar").HasMaxLength(500);
            this.Property(p => p.Url).HasColumnType("nvarchar(max)");

            this.HasRequired(p => p.Category).WithMany(p => p.Musics).HasForeignKey(p => p.Category_id);
            this.HasRequired(p => p.Artist).WithMany(p => p.Musics).HasForeignKey(p => p.Artist_id);
        }
     }
}
