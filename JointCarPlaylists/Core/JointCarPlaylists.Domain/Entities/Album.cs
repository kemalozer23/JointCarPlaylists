using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JointCarPlaylists.Domain.Entities
{
    public class Album
    {
        [Column("AlbumId")]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? ReleaseDate { get; set; }
        public int TotalTracks { get; set; }

        public string? AlbumType { get; set; }

        public string? ExternalUrl { get; set; }

        public string? Type { get; set; }

        public Artist? Artist { get; set; }
        public ICollection<Track>? Tracks { get; set; }
    }
}
