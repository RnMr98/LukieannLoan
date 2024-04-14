using LukieannLoanWeb.Data;
namespace LukieannLoanWeb.Contracts
{
    public interface IGenericRepository <T> where T : class
    {
        Task<T> GetAsync(int? id);
        Task<T> AddAsync(T entity);
        Task AddRange(T entity);
        Task UpdateAsync(T entity);
        Task<bool> Exists(int id);
        Task DeleteAsync(int id);
        Task<List<T>> GetAllAsync();

    }
}
