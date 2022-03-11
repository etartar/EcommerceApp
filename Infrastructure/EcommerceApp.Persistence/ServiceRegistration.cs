using EcommerceApp.Application.Abstractions;
using EcommerceApp.Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace EcommerceApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
