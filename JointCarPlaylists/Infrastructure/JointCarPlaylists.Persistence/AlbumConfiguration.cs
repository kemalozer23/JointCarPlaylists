using JointCarPlaylists.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JointCarPlaylists.Persistence
{
    public class AlbumConfiguration : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasData
            (
            new Album
            {
                Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                Name = "IT_Solutions Ltd",
                ReleaseDate = "1999",
                TotalTracks = 0,
                AlbumType = "Hip-Hop",
                ExternalUrl = "asdsadasd.com",
                Type = "Underground",
                ArtistId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a")
            },
            new Album
            {
                Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                Name = "Admin_Solutions Ltd",
                ReleaseDate = "2005",
                TotalTracks = 4,
                AlbumType = "Hip-Hop",
                ExternalUrl = "asds444adasd.com",
                Type = "Underground",
                ArtistId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a")
            }
            );
        }

    }
}
