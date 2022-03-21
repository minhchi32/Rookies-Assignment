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
                Price = 499000,
                DecreasedPrice = 399000,
                CategoryID = 4,
                QuantitySale = 970,
                TotalPointRate = 128,
                CountRate = 26
            },
            new Product()
            {
                ID = 2,
                Name = "Áo thun nam Cotton Compact phiên bản Premium chống nhăn",
                Price = 259000,
                DecreasedPrice = 0,
                CategoryID = 7,
                QuantitySale = 0,
                TotalPointRate = 0,
                CountRate = 0
            }
        );
    }
}