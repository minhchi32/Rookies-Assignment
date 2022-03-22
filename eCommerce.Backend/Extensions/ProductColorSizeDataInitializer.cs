namespace eCommerce.Backend.Extensions;

public static class ProductColorSizeDataInitializer
{
    public static void SeedProductColorSizeData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductColorSize>().HasData(
            new ProductColorSize() { ID = 1, ProductColorID = 1, Name = "M", Quantity = 0 },
            new ProductColorSize() { ID = 2, ProductColorID = 1, Name = "L", Quantity = 0 },
            new ProductColorSize() { ID = 3, ProductColorID = 1, Name = "XL", Quantity = 100 },
            new ProductColorSize() { ID = 4, ProductColorID = 1, Name = "2XL", Quantity = 20 },
            new ProductColorSize() { ID = 5, ProductColorID = 2, Name = "M", Quantity = 2 },
            new ProductColorSize() { ID = 6, ProductColorID = 2, Name = "L", Quantity = 0 },
            new ProductColorSize() { ID = 7, ProductColorID = 2, Name = "XL", Quantity = 1 },
            new ProductColorSize() { ID = 8, ProductColorID = 2, Name = "2XL", Quantity = 0 },
            new ProductColorSize() { ID = 9, ProductColorID = 3, Name = "S", Quantity = 2 },
            new ProductColorSize() { ID = 10, ProductColorID = 3, Name = "M", Quantity = 0 },
            new ProductColorSize() { ID = 11, ProductColorID = 3, Name = "L", Quantity = 0 },
            new ProductColorSize() { ID = 12, ProductColorID = 3, Name = "XL", Quantity = 100 },
            new ProductColorSize() { ID = 13, ProductColorID = 3, Name = "2XL", Quantity = 20 },
            new ProductColorSize() { ID = 14, ProductColorID = 4, Name = "S", Quantity = 2 },
            new ProductColorSize() { ID = 15, ProductColorID = 4, Name = "M", Quantity = 2 },
            new ProductColorSize() { ID = 16, ProductColorID = 4, Name = "L", Quantity = 0 },
            new ProductColorSize() { ID = 17, ProductColorID = 4, Name = "XL", Quantity = 1 },
            new ProductColorSize() { ID = 18, ProductColorID = 4, Name = "2XL", Quantity = 0 },
            new ProductColorSize() { ID = 19, ProductColorID = 5, Name = "S", Quantity = 2 },
            new ProductColorSize() { ID = 20, ProductColorID = 5, Name = "M", Quantity = 2 },
            new ProductColorSize() { ID = 21, ProductColorID = 5, Name = "L", Quantity = 0 },
            new ProductColorSize() { ID = 22, ProductColorID = 5, Name = "XL", Quantity = 1 },
            new ProductColorSize() { ID = 23, ProductColorID = 5, Name = "2XL", Quantity = 0 },
            new ProductColorSize() { ID = 24, ProductColorID = 6, Name = "S", Quantity = 2 },
            new ProductColorSize() { ID = 25, ProductColorID = 6, Name = "M", Quantity = 2 },
            new ProductColorSize() { ID = 26, ProductColorID = 6, Name = "L", Quantity = 0 },
            new ProductColorSize() { ID = 27, ProductColorID = 6, Name = "XL", Quantity = 1 },
            new ProductColorSize() { ID = 28, ProductColorID = 6, Name = "2XL", Quantity = 0 },
            new ProductColorSize() { ID = 29, ProductColorID = 7, Name = "S", Quantity = 2 },
            new ProductColorSize() { ID = 30, ProductColorID = 7, Name = "M", Quantity = 2 },
            new ProductColorSize() { ID = 31, ProductColorID = 7, Name = "L", Quantity = 0 },
            new ProductColorSize() { ID = 32, ProductColorID = 7, Name = "XL", Quantity = 1 },
            new ProductColorSize() { ID = 33, ProductColorID = 7, Name = "2XL", Quantity = 0 },
            new ProductColorSize() { ID = 34, ProductColorID = 8, Name = "M", Quantity = 0 },
            new ProductColorSize() { ID = 35, ProductColorID = 8, Name = "M", Quantity = 0 },
            new ProductColorSize() { ID = 36, ProductColorID = 8, Name = "L", Quantity = 0 },
            new ProductColorSize() { ID = 37, ProductColorID = 8, Name = "XL", Quantity = 0 },
            new ProductColorSize() { ID = 38, ProductColorID = 8, Name = "2XL", Quantity = 0 }
        );
    }
}