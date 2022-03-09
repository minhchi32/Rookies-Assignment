namespace eCommerce.Backend.Extensions;

public static class ProductColorDataInitializer
{
    public static void SeedProductColorData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductColor>().HasData(
            new ProductColor()
            {
                ID = 1,
                Name = "Đen",
                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/4-4_(1)_80x80.jpg",
                ProductID = 1,
            },
            new ProductColor()
            {
                ID = 2,
                Name = "Xanh rêu",
                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/7-2_80x80.jpg",
                ProductID = 1,

            },
            new ProductColor()
            {
                ID = 3,
                Name = "Đen",
                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/1-5avgg2cc_46_80x80.jpg",
                ProductID = 2,
            },
            new ProductColor()
            {
                ID = 4,
                Name = "Trắng",
                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/3-7a_80x80.jpg",
                ProductID = 2,
            },
            new ProductColor()
            {
                ID = 5,
                Name = "Xanh Navy",
                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/preimum_Tshirt_mau_xanh_navy_3_80x80.jpg",
                ProductID = 2,
            },
            new ProductColor()
            {
                ID = 6,
                Name = "Xám",
                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/2-5a23_80x80.jpg",
                ProductID = 2,
            },
            new ProductColor()
            {
                ID = 7,
                Name = "Xám chì",
                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/1-4_(2)_80x80.jpg",
                ProductID = 2,
            },
            new ProductColor()
            {
                ID = 8,
                Name = "Xanh lam",
                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/6-1_(1)a_80x80.jpg",
                ProductID = 2,
            }
        );
    }
}