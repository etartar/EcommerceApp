using EcommerceApp.Application.Repositories;
using EcommerceApp.Domain.Entities;
using EcommerceApp.Persistence.Contexts;

namespace EcommerceApp.Persistence.Repositories
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(SystemContext context) : base(context)
        {
        }
    }
}
