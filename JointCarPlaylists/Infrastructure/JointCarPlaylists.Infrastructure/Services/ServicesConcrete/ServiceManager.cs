using JointCarPlaylists.Application.Abstractions.Logger;
using JointCarPlaylists.Application.Abstractions.ServicesAbstract;
using JointCarPlaylists.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JointCarPlaylists.Infrastructure.Services.ServicesConcrete
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IAlbumService> _albumService;
        private readonly Lazy<IArtistService> _artistService;
        private readonly Lazy<ITrackService> _trackService;

        public ServiceManager(IRepositoryManager repository, ILoggerManager logger)
        {
            _albumService = new Lazy<IAlbumService>(() => new AlbumService(repository, logger));
            _artistService = new Lazy<IArtistService>(() => new ArtistService(repository, logger));
            _trackService = new Lazy<ITrackService>(() => new TrackService(repository, logger));
        }

        public IAlbumService AlbumService => _albumService.Value;
        public IArtistService ArtistService => _artistService.Value;
        public ITrackService TrackService => _trackService.Value;
    }
}
