using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Allsop.DataAccess.Migrations
{
    public class ProductCatalogDbContextFactory : IDesignTimeDbContextFactory<ProductCatalogDbContext>
    {
        public ProductCatalogDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ProductCatalogDbContext>()
                .UseSqlServer("localhost", x => x.MigrationsHistoryTable("__EFMigrationsHistoryProductCatalogDbContext")); // does not matter...

            return new ProductCatalogDbContext(optionsBuilder.Options);
        }
    }
}
