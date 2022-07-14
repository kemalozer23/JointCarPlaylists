using JointCarPlaylists.Application.Repositories.TrackRepository;
using JointCarPlaylists.Domain.Entities;
using JointCarPlaylists.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JointCarPlaylists.Persistence.Repositories
{
    public class TrackRepository : RepositoryBase<Track>, ITrackRepository
    {
        public TrackRepository(JointCarPlaylistsDbContext context) : base(context)
        {
        }

        public IEnumerable<Track> GetAllTracks(bool trackChanges) => FindAll(trackChanges).OrderBy(c => c.Name).ToList();
    }
}
