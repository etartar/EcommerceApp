using EcommerceApp.Application.Repositories;
using EcommerceApp.Domain.Entities;
using EcommerceApp.Persistence.Contexts;

namespace EcommerceApp.Persistence.Repositories
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(SystemContext context) : base(context)
        {
        }
    }
}
