using EcommerceApp.Application.Repositories;
using EcommerceApp.Persistence.Contexts;
using EcommerceApp.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EcommerceApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            services.AddDbContextPool<SystemContext>(options => options.UseNpgsql(Configuration.ConnectionString));
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
