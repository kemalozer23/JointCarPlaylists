using JointCarPlaylists.Application.Repositories.Artist;
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
    }
}
