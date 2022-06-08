using FZMusicEntites.Maps;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZMusicEntites.Models
{
    public class FZMusicContext : DbContext
    {
        public FZMusicContext() : base("FZMusicEntites")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ArtistMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new MusicMap());
            modelBuilder.Configurations.Add(new PlaylistMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new PlayListMusicMap());
            modelBuilder.Configurations.Add(new LikeMusicMap());
        }

        public DbSet<Category>Category { get; set; }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Music> Music { get; set; }
        public DbSet<Playlist> Playlist { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<PlayListMusic>  playListMusic { get; set; }
        public DbSet<LikeMusic> LikeMusics { get; set; }

    }
}
