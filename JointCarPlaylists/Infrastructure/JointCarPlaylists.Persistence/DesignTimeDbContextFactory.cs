using JointCarPlaylists.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JointCarPlaylists.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<JointCarPlaylistsDbContext>
    {
        public JointCarPlaylistsDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<JointCarPlaylistsDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);

            return new(dbContextOptionsBuilder.Options);
        }
    }
}