namespace RepositoryPattern.Business.Abstract.Commons
{
    public interface IReadAccess<T>
    {
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
    }
}
