using JointCarPlaylists.Application.Repositories.AlbumRepository;
using JointCarPlaylists.Application.Repositories.ArtistRepository;
using JointCarPlaylists.Application.Repositories.TrackRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JointCarPlaylists.Application.Repositories
{
    public interface IRepositoryManager
    {
        IAlbumRepository Album { get; }
        IArtistRepository Artist { get; }
        ITrackRepository Track { get; }

        void Save();
    }
}
