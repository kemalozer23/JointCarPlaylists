
using JointCarPlaylists.Application.Repositories.Album;
using JointCarPlaylists.Application.Repositories.Artist;
using JointCarPlaylists.Application.Repositories.Track;
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
