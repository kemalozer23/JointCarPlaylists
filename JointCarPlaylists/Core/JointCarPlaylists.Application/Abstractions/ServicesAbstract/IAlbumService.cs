﻿using JointCarPlaylists.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JointCarPlaylists.Application.Abstractions.ServicesAbstract
{
    public interface IAlbumService
    {
        IEnumerable<Album> GetAllAlbums(bool trackChanges);
    }
}
