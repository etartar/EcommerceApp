using EcommerceApp.Domain.Entities.Common;
using System.Linq.Expressions;

namespace EcommerceApp.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAllAsync(bool tracking = true);
        IQueryable<T> GetWhereAsync(Expression<Func<T, bool>> expression, bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> expression, bool tracking = true);
        Task<T> GetByIdAsync(string id, bool tracking = true);
    }
}
