using Allsop.Domain;
using Allsop.Domain.Services;
using Allsop.Service.Contract;
using Microsoft.Extensions.DependencyInjection;

namespace Allshop.ProductCatalog.Middleware
{
    public static class DomainServiceStartupExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}
