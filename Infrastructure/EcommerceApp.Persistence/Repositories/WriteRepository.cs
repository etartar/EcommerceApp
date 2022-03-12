using EcommerceApp.Application.Repositories;
using EcommerceApp.Domain.Entities.Common;
using EcommerceApp.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EcommerceApp.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly SystemContext _context;

        public WriteRepository(SystemContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T entity)
        {
            EntityEntry<T> result = await Table.AddAsync(entity);
            return result.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> entity)
        {
            await Table.AddRangeAsync(entity);
            return true;
        }

        public bool Remove(T entity)
        {
            EntityEntry<T> result = Table.Remove(entity);
            return result.State == EntityState.Deleted;
        }

        public async Task<bool> Remove(string id)
        {
            T model = await Table.FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));
            return Remove(model);
        }

        public bool RemoveRange(List<T> entity)
        {
            Table.RemoveRange(entity);
            return true;
        }

        public bool UpdateAsync(T entity)
        {
            EntityEntry<T> result = Table.Update(entity);
            return result.State == EntityState.Modified;
        }

        public async Task<int> SaveAsync() 
            => await _context.SaveChangesAsync();
    }
}
