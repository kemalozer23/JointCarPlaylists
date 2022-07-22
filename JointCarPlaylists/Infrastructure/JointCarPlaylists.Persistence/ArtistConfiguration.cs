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
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.HasData
            (
            new Artist
            {
                Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                Name = "Kendrick",
                ExternalUrl = "ted.com",
                Followers = 1232312,
                Popularity = 9,
                Type = "Hip-Hop",
                URI = "dsasdasdasd.com"
            }
            );
        }
    }
}
