using EcommerceApp.Application.Repositories;
using EcommerceApp.Domain.Entities;
using EcommerceApp.Persistence.Contexts;

namespace EcommerceApp.Persistence.Repositories
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(SystemContext context) : base(context)
        {
        }
    }
}
