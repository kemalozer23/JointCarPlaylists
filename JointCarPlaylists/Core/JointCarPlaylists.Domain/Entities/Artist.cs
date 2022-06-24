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

        public ICollection<Track>? Tracks { get; set; }

        public Album? Album { get; set; }
    }
}
