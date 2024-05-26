using RepositoryPattern.DataAccess.Abstract.Communs;
using RepositoryPattern.Entity;

namespace RepositoryPattern.DataAccess.UnitOfWork
{
    internal interface IUow
    {
        public IBaseRepository<Product, int> ProductRepository { get; set; }
        public IBaseRepository<Category, int> CategoryRepository { get; set; }

        public Task CommitAsync();
    }
}
