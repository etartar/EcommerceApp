using EcommerceApp.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApp.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
