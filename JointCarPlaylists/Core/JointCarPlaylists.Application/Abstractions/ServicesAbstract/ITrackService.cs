﻿using JointCarPlaylists.Application.DTOs;
using JointCarPlaylists.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JointCarPlaylists.Application.Abstractions.ServicesAbstract
{
    public interface ITrackService
    {
        IEnumerable<TrackDto> GetAllTracks(bool trackChanges);
    }
}
