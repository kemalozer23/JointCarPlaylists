using JointCarPlaylists.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JointCarPlaylists.Application.Repositories.TrackRepository
{
    public interface ITrackRepository
    {
        IEnumerable<Track> GetAllTracks(bool trackChanges);
    }
}
