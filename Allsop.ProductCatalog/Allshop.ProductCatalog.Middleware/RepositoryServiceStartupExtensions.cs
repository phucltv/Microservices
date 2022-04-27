using Allsop.DataAccess.Contract.Repository;
using Allsop.DataAccess.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Allshop.ProductCatalog.Middleware
{
    public static class RepositoryServiceStartupExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
        }
    }
}
