using RepositoryPattern.Entity;

namespace RepositoryPattern.DataAccess.Abstract.Communs
{
    public interface IChangeAccess<TEntity, in TPrimary> : IDisposable
        where TEntity : BaseEntity<TPrimary>
    {
        Task<TEntity> CreateAsync(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(TEntity entity);
    }
}
