using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JointCarPlaylists.Domain.Entities;

namespace JointCarPlaylists.Application.Repositories.AlbumRepository
{
    public interface IAlbumRepository
    {
        IEnumerable<Album> GetAllAlbums(bool trackChanges);
    }
}
