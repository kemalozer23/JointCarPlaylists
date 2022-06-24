using JointCarPlaylists.Application;
using JointCarPlaylists.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JointCarPlaylists.Persistence.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected JointCarPlaylistsDbContext _jointCarPlaylistsDbContext;

        public RepositoryBase(JointCarPlaylistsDbContext jointCarPlaylistsDbContext) => _jointCarPlaylistsDbContext = jointCarPlaylistsDbContext;

        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ? _jointCarPlaylistsDbContext.Set<T>().AsNoTracking() : _jointCarPlaylistsDbContext.Set<T>();
        
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges ? _jointCarPlaylistsDbContext.Set<T>().Where(expression).AsNoTracking() : _jointCarPlaylistsDbContext.Set<T>().Where(expression);
        
        public void Create(T entity) => _jointCarPlaylistsDbContext.Set<T>().Add(entity);
        
        public void Update(T entity) => _jointCarPlaylistsDbContext.Set<T>().Update(entity);

        public void Delete(T entity) => _jointCarPlaylistsDbContext.Set<T>().Remove(entity);
    }
}
