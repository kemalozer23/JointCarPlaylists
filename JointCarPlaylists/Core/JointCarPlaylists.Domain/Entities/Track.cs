using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JointCarPlaylists.Domain.Entities
{
    public class Track
    {
        [Column("TrackId")]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int? TrackNumber { get; set; }

        public Artist? Artist { get; set; }
    }
}
