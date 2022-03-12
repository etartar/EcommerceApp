using EcommerceApp.Application.Repositories;
using EcommerceApp.Domain.Entities;
using EcommerceApp.Persistence.Contexts;

namespace EcommerceApp.Persistence.Repositories
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(SystemContext context) : base(context)
        {
        }
    }
}
