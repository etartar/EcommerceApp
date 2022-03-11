using EcommerceApp.Domain.Entities;

namespace EcommerceApp.Application.Abstractions
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
