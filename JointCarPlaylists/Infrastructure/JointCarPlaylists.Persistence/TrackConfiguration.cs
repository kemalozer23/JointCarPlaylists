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
    public class TrackConfiguration : IEntityTypeConfiguration<Track>
    {
        public void Configure(EntityTypeBuilder<Track> builder)
        {
            builder.HasData
            (
            new Track
            {
                Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                Name = "Sam Raiden",
                TrackNumber = 2,
                DurationMS = 5000,
                Explicit = true,
                ExternalURL = "sedasdas.com",
                Popularity = 34,
                Type = "Underground",
                URI = "losakdfdf.com"
            },
            new Track
            {
                Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                Name = "Jana McLeaf",
                TrackNumber = 3,
                DurationMS = 4000,
                Explicit = true,
                ExternalURL = "sewresdas.com",
                Popularity = 64,
                Type = "Underground",
                URI = "lossdsdfdfdf.com"
            },
            new Track
            {
                Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                Name = "Kane Miller",
                TrackNumber = 4,
                DurationMS = 500,
                Explicit = false,
                ExternalURL = "sedasds.com",
                Popularity = 74,
                Type = "Underground",
                URI = "losdfdf.com"
            }
            );
        }

    }
}
