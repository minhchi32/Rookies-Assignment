namespace eCommerce.Backend.Extensions;

public static class ProductDataInitializer
{
    public static void SeedProductData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product()
            {
                ID = 1,
                Name = "Áo khoác đa năng cản gió và chống UV",
                Description = "",
                Price = 499000,
                DecreasedPrice = 399000,
                CategoryID = 4,
                SeoTitle = "ao-khoac-da-nang-kinh-chan-giot-ban-faceshield",
                QuantitySale = 970,
                TotalPointRate = 128,
                CountRate = 26
            },
            new Product()
            {
                ID = 2,
                Name = "Áo thun nam Cotton Compact phiên bản Premium chống nhăn",
                Description = "",
                Price = 259000,
                DecreasedPrice = 0,
                CategoryID = 7,
                SeoTitle = "ao-thun-nam-cotton-compact-chong-nhan",
                QuantitySale = 0,
                TotalPointRate = 0,
                CountRate = 0
            }
        );
    }
}