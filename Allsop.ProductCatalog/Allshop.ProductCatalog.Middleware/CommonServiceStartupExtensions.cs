using Allsop.Common.Mediator;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;

namespace Allshop.ProductCatalog.Middleware
{
    public static class CommonServiceStartupExtensions
    {
        public static void AddCommonServices(this IServiceCollection services)
        {
            services.AddRequestScoped<IScopedMediator, ScopedMediator>();
            services.AddRequestScoped<IMemoryCache, MemoryCache>();
        }
    }
}
