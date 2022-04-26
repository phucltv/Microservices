namespace Allsop.DataAccess
{
    internal static class GenerateTestData
    {
        private static bool hasGeneratePrudct = false;

        public static void GenerateProductCategoryData(ProductCatalogDbContext dbContext)
        {
            if (hasGeneratePrudct)
            {
                return;
            }

            hasGeneratePrudct = true;

            dbContext.Categories.AddRange(TestData.Categories());
            dbContext.Products.AddRange(TestData.Products());

            dbContext.SaveChanges();
        }

    }
}
