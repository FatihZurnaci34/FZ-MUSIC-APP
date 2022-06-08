using FZMusicEntites.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FZMusicEntites.Maps
{
    public class ArtistMap : EntityTypeConfiguration<Artist>
    {
        public ArtistMap()
        {
            this.ToTable("tblArtist");
            this.Property(p => p.Id).HasColumnType("int");
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Name).HasColumnType("nvarchar").HasMaxLength(100);
            this.Property(p => p.Surname).HasColumnType("nvarchar").HasMaxLength(100);

            
        }
    }


}

