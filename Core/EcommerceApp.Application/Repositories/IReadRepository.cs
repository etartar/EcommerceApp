using EcommerceApp.Domain.Entities.Common;
using System.Linq.Expressions;

namespace EcommerceApp.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAllAsync();
        IQueryable<T> GetWhereAsync(Expression<Func<T, bool>> expression);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> expression);
        Task<T> GetByIdAsync(string id);
    }
}
