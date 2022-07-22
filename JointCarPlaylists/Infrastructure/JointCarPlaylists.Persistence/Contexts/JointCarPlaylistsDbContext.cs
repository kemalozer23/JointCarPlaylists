using JointCarPlaylists.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JointCarPlaylists.Persistence.Contexts
{
    public class JointCarPlaylistsDbContext : DbContext
    {
        public JointCarPlaylistsDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlbumConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistConfiguration());
            modelBuilder.ApplyConfiguration(new TrackConfiguration());

            modelBuilder.Entity<Album>()
                        .HasOne(p => p.Artist)
                        .WithMany(b => b.Albums)
                        .HasForeignKey(p => p.ArtistForeignKey);

        }

        public DbSet<Album>? Albums { get; set; }
        public DbSet<Artist>? Artists { get; set; }
        public DbSet<Track>? Tracks { get; set; }
    }
}
