namespace Intranet.Domain.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetListAsync();

        Task<T> GetAsync(int id);

        Task<T> InsertAsync(T todoItem);

        Task<T> UpdateAsync(int id, T todoItem);

        Task DeleteAsync(int id);
    }
}
