using EcommerceApp.Domain.Entities.Common;

namespace EcommerceApp.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> entity);
        bool Remove(T entity);
        bool RemoveRange(List<T> entity);
        Task<bool> Remove(string id);
        bool UpdateAsync(T entity);
        Task<int> SaveAsync();
    }
}
