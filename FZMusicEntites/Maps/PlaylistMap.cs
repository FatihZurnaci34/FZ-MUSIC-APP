using FZMusicEntites.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FZMusicEntites.Maps
{
    public class PlaylistMap : EntityTypeConfiguration<Playlist>
    {
        public PlaylistMap()
        {
            this.ToTable("tblPlayList");
            this.Property(p => p.Id).HasColumnType("int");
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Name).HasColumnType("nvarchar").HasMaxLength(100);

            this.HasRequired(p => p.User).WithMany(p => p.Playlists).HasForeignKey(p => p.User_id);
        }
    }
       


}

