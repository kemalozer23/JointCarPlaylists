using JointCarPlaylists.Application.Repositories;
using JointCarPlaylists.Application.Repositories.Album;
using JointCarPlaylists.Application.Repositories.Artist;
using JointCarPlaylists.Application.Repositories.Track;
using JointCarPlaylists.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JointCarPlaylists.Persistence.Repositories
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly JointCarPlaylistsDbContext _context;
        private readonly Lazy<IAlbumRepository> _albumRepository;
        private readonly Lazy<IArtistRepository> _artistRepository;
        private readonly Lazy<ITrackRepository> _trackRepository;

        public RepositoryManager(JointCarPlaylistsDbContext context)
        {
            _context = context;
            _albumRepository = new Lazy<IAlbumRepository>(() => new AlbumRepository(context));
            _artistRepository = new Lazy<IArtistRepository>(() => new ArtistRepository(context));
            _trackRepository = new Lazy<ITrackRepository>(() => new TrackRepository(context));
        }

        public IAlbumRepository Album => _albumRepository.Value;
        public IArtistRepository Artist => _artistRepository.Value;
        public ITrackRepository Track => _trackRepository.Value;

        public void Save() => _context.SaveChanges();
    }
}
