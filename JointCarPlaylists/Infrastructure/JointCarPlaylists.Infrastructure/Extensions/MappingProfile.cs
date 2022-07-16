using AutoMapper;
using JointCarPlaylists.Application.DTOs;
using JointCarPlaylists.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JointCarPlaylists.Infrastructure.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Album, AlbumDto>().ForCtorParam("ArtistName", opt => opt.MapFrom(x => x.Artist.Name));
            CreateMap<Album, AlbumDto>().ForCtorParam("Tracks", opt => opt.MapFrom(x => x.Tracks.ToList()));

            CreateMap<Artist, ArtistDto>().ForCtorParam("AlbumNames", opt => opt.MapFrom(x => x.Albums.ToList()));
            CreateMap<Artist, ArtistDto>().ForCtorParam("TrackNames", opt => opt.MapFrom(x => x.Tracks.ToList()));

            CreateMap<Track, TrackDto>().ForCtorParam("ArtistName", opt => opt.MapFrom(x => x.Artist.Name));
            CreateMap<Track, TrackDto>().ForCtorParam("AlbumName", opt => opt.MapFrom(x => x.Album.Name));
        }
    }
}
