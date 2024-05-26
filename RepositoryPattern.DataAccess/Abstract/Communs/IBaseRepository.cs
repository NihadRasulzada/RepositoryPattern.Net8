using RepositoryPattern.Entity;

namespace RepositoryPattern.DataAccess.Abstract.Communs
{
    public interface IBaseRepository<TEntity,in TPrimary> : IDisposable,
        IChangeAccess<TEntity, TPrimary>,
        IReadAccess<TEntity, TPrimary>
        where TEntity : BaseEntity<TPrimary>
    {
    }
}
