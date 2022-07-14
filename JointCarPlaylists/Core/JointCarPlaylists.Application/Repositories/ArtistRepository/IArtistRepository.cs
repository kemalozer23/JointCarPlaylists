using JointCarPlaylists.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JointCarPlaylists.Application.Repositories.ArtistRepository
{
    public interface IArtistRepository
    {
        IEnumerable<Artist> GetAllArtists(bool trackChanges);
    }
}
