using EcommerceApp.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository = null)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpPost]
        public async Task CreateProduct()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new() { Id = Guid.NewGuid(), Name = "Product 1", Price = 100, Stock = 10, CreatedDate = DateTime.UtcNow },
                new() { Id = Guid.NewGuid(), Name = "Product 2", Price = 200, Stock = 20, CreatedDate = DateTime.UtcNow },
                new() { Id = Guid.NewGuid(), Name = "Product 3", Price = 300, Stock = 110, CreatedDate = DateTime.UtcNow },
            });

            await _productWriteRepository.SaveAsync();
        }
    }
}
