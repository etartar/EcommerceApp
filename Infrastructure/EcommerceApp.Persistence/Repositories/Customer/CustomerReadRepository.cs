using EcommerceApp.Application.Repositories;
using EcommerceApp.Domain.Entities;
using EcommerceApp.Persistence.Contexts;

namespace EcommerceApp.Persistence.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(SystemContext context) : base(context)
        {
        }
    }
}
