using JointCarPlaylists.Application.Abstractions.Logger;
using JointCarPlaylists.Application.Abstractions.ServicesAbstract;
using JointCarPlaylists.Application.Repositories;
using JointCarPlaylists.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JointCarPlaylists.Infrastructure.Services.ServicesConcrete
{
    internal sealed class TrackService : ITrackService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public TrackService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public IEnumerable<Track> GetAllTracks(bool trackChanges)
        {
            try
            {
                var tracks = _repository.Track.GetAllTracks(trackChanges);

                return tracks;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the { nameof(GetAllTracks)} service method { ex}");
                throw;
            }
        }
    }
}
