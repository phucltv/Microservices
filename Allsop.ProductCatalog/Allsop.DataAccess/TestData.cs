using Allsop.DataAccess.Model;

namespace Allsop.DataAccess
{
    public static class TestData
    {
        public static IEnumerable<CategoryDb> Categories()
        {
            return new List<CategoryDb>()
            {
                new CategoryDb()
                {
                    Id = new Guid("28458754-096F-4238-B4BC-98C31D7FCD5A"),
                    Name = "Drinks"
                },
                new CategoryDb()
                {
                    Id = new Guid("8FD884CD-E251-4195-AF3B-342D86CDE8E4"),
                    Name = "Meat & Poultry"
                },
                new CategoryDb()
                {
                    Id = new Guid("6F75EE04-2B4B-4686-8449-FC6FB1E385A2"),
                    Name = "Fruit & Vegetables"
                },
                new CategoryDb()
                {
                    Id = new Guid("299688E8-EC06-44B0-A17B-A572F7D43A11"),
                    Name = "Confectionary & Desserts"
                },
                new CategoryDb()
                {
                    Id = new Guid("322886CA-D633-4C89-A975-6626C6F32E8A"),
                    Name = "Baking/Cooking Ingredients"
                },
                new CategoryDb()
                {
                    Id = new Guid("27166FB8-B922-4FA4-A4AC-784E1F280168"),
                    Name = "Miscellaneous Items"
                }
            };
        }

        public static IEnumerable<ProductDb> Products()
        {
            return new List<ProductDb>()
            {
                //Drinks
                new ProductDb()
                {
                    Id = new Guid("A5546E3D-7ACE-422E-886B-99F2A91090C7"),
                    Name = "Coca-Cola, 6 x 2L",
                    CategoryId = new Guid("28458754-096F-4238-B4BC-98C31D7FCD5A"),
                    Price = 4.5m,
                    Quantity = 12
                },
                new ProductDb()
                {
                    Id = new Guid("234DF2B9-89E7-4881-9120-A52D3CC0A6E6"),
                    Name = "Still Mineral Water, 6 x 24 x 500ml",
                    CategoryId = new Guid("28458754-096F-4238-B4BC-98C31D7FCD5A"),
                    Price = 45.7m,
                    Quantity = 6
                },
                new ProductDb()
                {
                    Id = new Guid("5F9D8F34-5703-494D-A961-5E6A3147D0DA"),
                    Name = "Chicken Fillets, 6 x 100g",
                    CategoryId = new Guid("28458754-096F-4238-B4BC-98C31D7FCD5A"),
                    Price = 43.2m,
                    Quantity = 8
                },

                //Fruit
                new ProductDb()
                {
                    Id = new Guid("837C78F3-0299-49CE-A8F9-A51FA5D7DEFD"),
                    Name = "Granny Smith Apples, 4 x 16 each Fruit & Vegetables",
                    CategoryId = new Guid("6F75EE04-2B4B-4686-8449-FC6FB1E385A2"),
                    Price = 3.75m,
                    Quantity = 0
                },
                new ProductDb()
                {
                    Id = new Guid("539AA645-8AE8-44AF-83CA-4893E32C2BBA"),
                    Name = "Loose Carrots, 4 x 20 each Fruit & Vegetables",
                    CategoryId = new Guid("6F75EE04-2B4B-4686-8449-FC6FB1E385A2"),
                    Price = 2.67m,
                    Quantity = 2
                },
                new ProductDb()
                {
                    Id = new Guid("5F4C10FF-A692-49A8-AEEB-876D8D845586"),
                    Name = "Mandarin Oranges, 6 x 10 x 12",
                    CategoryId = new Guid("6F75EE04-2B4B-4686-8449-FC6FB1E385A2"),
                    Price = 12.23m,
                    Quantity = 8
                },
                new ProductDb()
                {
                    Id = new Guid("F757F0C0-2CC6-4D70-82C3-71F0EE278190"),
                    Name = "Cauliflower Florets, 10 x 500g",
                    CategoryId = new Guid("6F75EE04-2B4B-4686-8449-FC6FB1E385A2"),
                    Price = 5m,
                    Quantity = 5
                },

                //Meat
                new ProductDb()
                {
                    Id = new Guid("C75CB909-35AA-40EF-BD6F-D60A2205F33A"),
                    Name = "Chicken Fillets, 6 x 100g",
                    CategoryId = new Guid("8FD884CD-E251-4195-AF3B-342D86CDE8E4"),
                    Price = 100,
                    Quantity = 10
                },
                new ProductDb()
                {
                    Id = new Guid("094D5686-F649-4854-8358-A0274DAC7B9F"),
                    Name = "Sirloin Steaks, 4 x 6-8oz",
                    CategoryId = new Guid("8FD884CD-E251-4195-AF3B-342D86CDE8E4"),
                    Price = 4.50m,
                    Quantity = 12
                },
                new ProductDb()
                {
                    Id = new Guid("5B71B066-9E80-4B2C-A7B2-0ED6016DBAE5"),
                    Name = "Whole Free-Range Turkey, 1 x 16-18lbs",
                    CategoryId = new Guid("8FD884CD-E251-4195-AF3B-342D86CDE8E4"),
                    Price = 45.70m,
                    Quantity = 6
                },

                //Confectionary 
                new ProductDb()
                {
                    Id = new Guid("3F2D59F8-5E17-4482-BE22-7ADBF89F4E4B"),
                    Name = "Mars Bar, 6 x 24 x 50g",
                    CategoryId = new Guid("8FD884CD-E251-4195-AF3B-342D86CDE8E4"),
                    Price = 42.82m,
                    Quantity = 4
                },
                new ProductDb()
                {
                    Id = new Guid("87684642-2F7A-4817-963D-8C55C5098705"),
                    Name = "Peppermint Chewing Gum, 6 x 50 x 30g",
                    CategoryId = new Guid("8FD884CD-E251-4195-AF3B-342D86CDE8E4"),
                    Price = 35.70m,
                    Quantity = 6
                },
                new ProductDb()
                {
                    Id = new Guid("50566EFD-4E6B-4BAE-A920-0F0DA24BFE76"),
                    Name = "Strawberry Cheesecake, 4 x 12 portions",
                    CategoryId = new Guid("8FD884CD-E251-4195-AF3B-342D86CDE8E4"),
                    Price = 8.52m,
                    Quantity = 0
                },
                new ProductDb()
                {
                    Id = new Guid("D8BA3ADD-9F58-4F2F-BB41-6CE6220A9F2B"),
                    Name = "Vanilla Ice Cream, 6 x 4L",
                    CategoryId = new Guid("8FD884CD-E251-4195-AF3B-342D86CDE8E4"),
                    Price = 3.8m,
                    Quantity = 2
                },
                //Baking/Cooking Ingredients 
                new ProductDb()
                {
                    Id = new Guid("9A8EDC2B-8362-44AC-8081-C74D2A977F8F"),
                    Name = "Plain Flour, 10 x 1kg",
                    CategoryId = new Guid("322886CA-D633-4C89-A975-6626C6F32E8A"),
                    Price = 42.82m,
                    Quantity = 4
                },
                new ProductDb()
                {
                    Id = new Guid("11F53620-F8AD-4EC8-8711-363987FEB80F"),
                    Name = "Icing Sugar, 12 x 500g",
                    CategoryId = new Guid("322886CA-D633-4C89-A975-6626C6F32E8A"),
                    Price = 35.70m,
                    Quantity = 6
                },
                new ProductDb()
                {
                    Id = new Guid("9321AFC7-0545-4ECA-BB56-23354A2EB77F"),
                    Name = "Free-Range Eggs, 10 x 12 each",
                    CategoryId = new Guid("322886CA-D633-4C89-A975-6626C6F32E8A"),
                    Price = 8.52m,
                    Quantity = 0
                },
                new ProductDb()
                {
                    Id = new Guid("D52E3153-8B4A-4BDD-BCA3-115F6ABFD81E"),
                    Name = "Caster Sugar, 16 x 750g",
                    CategoryId = new Guid("322886CA-D633-4C89-A975-6626C6F32E8A"),
                    Price = 3.8m,
                    Quantity = 2
                }
            }.AsEnumerable();
        }
    }
}
