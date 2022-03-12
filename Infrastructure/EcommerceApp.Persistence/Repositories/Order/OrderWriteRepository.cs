using EcommerceApp.Application.Repositories;
using EcommerceApp.Domain.Entities;
using EcommerceApp.Persistence.Contexts;

namespace EcommerceApp.Persistence.Repositories
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(SystemContext context) : base(context)
        {
        }
    }
}
