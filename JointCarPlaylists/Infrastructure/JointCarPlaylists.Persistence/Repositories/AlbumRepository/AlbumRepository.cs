using JointCarPlaylists.Application.Repositories.AlbumRepository;
using JointCarPlaylists.Persistence.Contexts;
using JointCarPlaylists.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JointCarPlaylists.Persistence.Repositories
{
    public class AlbumRepository : RepositoryBase<Album>, IAlbumRepository
    {
        public AlbumRepository(JointCarPlaylistsDbContext context) : base(context)
        {
        }

        public IEnumerable<Album> GetAllAlbums(bool trackChanges) => FindAll(trackChanges).OrderBy(c => c.Name).ToList();
    }
}
