using RepositoryPattern.Entity;

namespace RepositoryPattern.DataAccess.Abstract.Communs
{
    public interface IReadAccess<TEntity, in TPrimary> : IDisposable
        where TEntity : BaseEntity<TPrimary>
    {
        Task<List<TEntity>> GetALlAsync();
        Task<TEntity?> GetByIdAsync(int? id);
    }
}
