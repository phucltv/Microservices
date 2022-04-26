﻿using Allsop.Domain;
using Allsop.Domain.Services;
using Allsop.Service.Contract;

namespace Allsop.Api
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
