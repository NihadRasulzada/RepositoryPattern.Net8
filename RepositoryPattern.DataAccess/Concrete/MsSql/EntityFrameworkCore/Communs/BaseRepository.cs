using Microsoft.EntityFrameworkCore;
using RepositoryPattern.DataAccess.Abstract.Communs;
using RepositoryPattern.DataAccess.Context;
using RepositoryPattern.Entity;

namespace RepositoryPattern.DataAccess.Concrete.MsSql.EntityFrameworkCore.Communs
{
    public class BaseRepository<TEntity, TPrimary> : IBaseRepository<TEntity, TPrimary> 
        where TEntity : BaseEntity<TPrimary>
    {
        private readonly AppDbContext _context;
       // private DbSet<TEntity> Table => _dbContext.Set<TEntity>();

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> CreateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetALlAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity?> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
