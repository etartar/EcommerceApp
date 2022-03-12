using EcommerceApp.Application.Repositories;
using EcommerceApp.Domain.Entities.Common;
using EcommerceApp.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EcommerceApp.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly SystemContext _context;

        public ReadRepository(SystemContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAllAsync() 
            => Table;

        public IQueryable<T> GetWhereAsync(Expression<Func<T, bool>> expression) 
            => Table.Where(expression);

        public async Task<T> GetByIdAsync(string id)
            => await Table.FindAsync(Guid.Parse(id));

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression)
            => await Table.FirstOrDefaultAsync(expression);
    }
}
