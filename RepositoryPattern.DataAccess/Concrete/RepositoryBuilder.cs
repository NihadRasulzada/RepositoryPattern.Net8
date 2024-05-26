using RepositoryPattern.DataAccess.Abstract.Communs;
using RepositoryPattern.DataAccess.Concrete.MsSql.EntityFrameworkCore.Communs;
using RepositoryPattern.DataAccess.Context;
using RepositoryPattern.Entity;

namespace RepositoryPattern.DataAccess.Concrete
{
    public class RepositoryBuilder<TEntity,  TPrimary>
        where TEntity : BaseEntity<TPrimary>
    {
        public static IBaseRepository<TEntity, TPrimary> BuildRepository
            (IBaseRepository<TEntity, TPrimary> repository, AppDbContext context)
        {
            if(repository == null)
            {
                repository = new BaseRepository<TEntity, TPrimary>(context);
            }
            return repository;
        }
    }
}
