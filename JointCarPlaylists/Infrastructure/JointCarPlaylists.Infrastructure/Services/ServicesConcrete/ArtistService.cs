using AutoMapper;
using JointCarPlaylists.Application.Abstractions.Logger;
using JointCarPlaylists.Application.Abstractions.ServicesAbstract;
using JointCarPlaylists.Application.DTOs;
using JointCarPlaylists.Application.Repositories;
using JointCarPlaylists.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JointCarPlaylists.Infrastructure.Services.ServicesConcrete
{
    internal sealed class ArtistService : IArtistService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ArtistService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<ArtistDto> GetAllArtists(bool trackChanges)
        {
            try
            {
                var artists = _repository.Artist.GetAllArtists(trackChanges);

                var artistsDto = _mapper.Map<IEnumerable<ArtistDto>>(artists);

                return artistsDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the { nameof(GetAllArtists)} service method { ex}");
                throw;
            }
        }
    }
}
