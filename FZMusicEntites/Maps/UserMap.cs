using FZMusicEntites.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FZMusicEntites.Maps
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            this.ToTable("tblUser");
            this.Property(p => p.Id).HasColumnType("int");
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Name).HasColumnType("nvarchar").HasMaxLength(100);
            this.Property(p => p.Password).HasColumnType("nvarchar").HasMaxLength(100);
            this.Property(p => p.Email).HasColumnType("nvarchar").HasMaxLength(100);
            this.Property(p => p.DogumTarihi).HasColumnType("date");
        }
    }
    



}

