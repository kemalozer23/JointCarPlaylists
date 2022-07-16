using JointCarPlaylists.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JointCarPlaylists.Application.DTOs
{
    public record TrackDto(Guid Id, string Name, string ArtistName, string AlbumName);
}
