using RepositoryPattern.DataAccess.Abstract.Communs;
using RepositoryPattern.DataAccess.Concrete;
using RepositoryPattern.DataAccess.Context;
using RepositoryPattern.Entity;
using RepositoryPattern.Entity.Student;

namespace RepositoryPattern.DataAccess.UnitOfWork
{
    public class Uow : IUow
    {
        private readonly AppDbContext _context;
        public Uow(AppDbContext context)
        {
            _context = context;
        }

        private IBaseRepository<Product, int> _productRepository;
        public IBaseRepository<Product, int> ProductRepository
        {
            get => RepositoryBuilder<Product, int>.BuildRepository(_productRepository, _context);
            set => _productRepository = value;
        }

        private IBaseRepository<Category, int> _categoryRepository;
        public IBaseRepository<Category, int> CategoryRepository
        {
            get => RepositoryBuilder<Category, int>.BuildRepository(_categoryRepository, _context);
            set => _categoryRepository = value;
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
