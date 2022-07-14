using JointCarPlaylists.Application.Repositories.ArtistRepository;
using JointCarPlaylists.Domain.Entities;
using JointCarPlaylists.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JointCarPlaylists.Persistence.Repositories
{
    public class ArtistRepository : RepositoryBase<Artist>, IArtistRepository
    {
        public ArtistRepository(JointCarPlaylistsDbContext context) : base(context)
        {
        }

        public IEnumerable<Artist> GetAllArtists(bool trackChanges) => FindAll(trackChanges).OrderBy(c => c.Name).ToList();
    }
}
