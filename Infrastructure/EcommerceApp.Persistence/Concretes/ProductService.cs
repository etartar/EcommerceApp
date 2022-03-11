using EcommerceApp.Application.Abstractions;
using EcommerceApp.Domain.Entities;

namespace EcommerceApp.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
            => new()
            {
                new() { Id = Guid.NewGuid(), Name = "Product 1", Stock = 100, Price = 300, CreatedDate = DateTime.Now },
                new() { Id = Guid.NewGuid(), Name = "Product 2", Stock = 100, Price = 400, CreatedDate = DateTime.Now },
                new() { Id = Guid.NewGuid(), Name = "Product 3", Stock = 100, Price = 500, CreatedDate = DateTime.Now },
                new() { Id = Guid.NewGuid(), Name = "Product 4", Stock = 100, Price = 600, CreatedDate = DateTime.Now },
                new() { Id = Guid.NewGuid(), Name = "Product 5", Stock = 100, Price = 700, CreatedDate = DateTime.Now },
            };
    }
}
