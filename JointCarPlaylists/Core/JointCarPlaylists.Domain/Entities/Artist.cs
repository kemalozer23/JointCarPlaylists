 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JointCarPlaylists.Domain.Entities
{
    public class Artist
    {
        [Column("ArtistId")]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? ExternalUrl { get; set; }
        public int? Followers { get; set; }
        public int? Popularity { get; set; }
        public string? Type { get; set; }
        public string? URI { get; set; }

        public ICollection<Track>? Tracks { get; set; }

        public ICollection<Album>? Albums { get; set; }
    }
}
