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

    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        /// <summary>
        /// ctor -> 2 defa tab otomatik constructor oluşturur
        /// </summary>
        public CategoryMap()
        {
            this.ToTable("tblCategory");
            this.Property(p => p.Id).HasColumnType("int");
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Name).HasColumnType("nvarchar").HasMaxLength(100);
        }
    }


}

