using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JointCarPlaylists.Application.Abstractions.ServicesAbstract
{
    public interface IServiceManager
    {
        IAlbumService AlbumService { get; }
        IArtistService ArtistService { get; }
        ITrackService TrackService { get; }
    }
}
