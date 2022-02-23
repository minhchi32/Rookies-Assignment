using eCommerce.Backend.Models;
using Microsoft.EntityFrameworkCore;
using RookieShop.Shared.Enums;

namespace eCommerce.Backend.Extensions;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category() { ID = 1, Name = "Áo", Description = "", SeoTitle = "ao", ParentId = null, Status = Status.Show },
            new Category() { ID = 2, Name = "Quần", Description = "", SeoTitle = "quan", ParentId = null, Status = Status.Show },
            new Category() { ID = 3, Name = "Khác", Description = "", SeoTitle = "khac", ParentId = null, Status = Status.Show },
            new Category() { ID = 4, Name = "Áo khoác", Description = "", SeoTitle = "ao-khoac", ParentId = 1, Status = Status.Show },
            new Category() { ID = 5, Name = "Áo dài tay", Description = "", SeoTitle = "ao-dai-tay", ParentId = 1, Status = Status.Show },
            new Category() { ID = 6, Name = "Áo Polo", Description = "", SeoTitle = "ao-polo", ParentId = 1, Status = Status.Show },
            new Category() { ID = 7, Name = "Áo T-Shirt", Description = "", SeoTitle = "ao-t-shirt", ParentId = 1, Status = Status.Show },
            new Category() { ID = 8, Name = "Áo sơ mi", Description = "", SeoTitle = "ao-so-mi", ParentId = 1, Status = Status.Show },
            new Category() { ID = 9, Name = "Áo thể thao", Description = "", SeoTitle = "ao-the-thao", ParentId = 1 },
            new Category() { ID = 10, Name = "Áo in hình", Description = "", SeoTitle = "ao-in-hinh", ParentId = 1 },
            new Category() { ID = 11, Name = "Quần sọt", Description = "", SeoTitle = "quan-sot", ParentId = 2 },
            new Category() { ID = 12, Name = "Quần dài", Description = "", SeoTitle = "quan-dai", ParentId = 2 },
            new Category() { ID = 13, Name = "Quần lót nam", Description = "", SeoTitle = "quan-lot", ParentId = 2 },
            new Category() { ID = 14, Name = "Tất (vớ)", Description = "", SeoTitle = "tat", ParentId = 3 },
            new Category() { ID = 15, Name = "Phụ kiện", Description = "", SeoTitle = "phu-kien", ParentId = 3 }
            );

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
                SeoDescription = "",
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
                SeoDescription = "",
                QuantitySale = 0,
                TotalPointRate = 0,
                CountRate = 0
            }/*,
            new Product()
            {
                ID = 2,
                Name = "",
                Description = "",
                Price = 0,
                DecreasedPrice = 0,
                CategoryID = 0,
                SeoTitle = "",
                SeoDescription = "",
                QuantitySale = 0,
                TotalPointRate = 0,
                CountRate = 0,
                Rates = new List<Rate>(){
                },
                ProductColors = new List<ProductColor>()
                {
                    new ProductColor()
                    {
                        Name = "Đen",
                        PathImage = "",
                        ProductID = 2,
                        ProductColorImages = new List<ProductColorImage>()
                        {
                            new ProductColorImage()
                            {
                                ProductColorID = 1, 
                                Name = "", 
                                PathImage = ""
                            },
                            new ProductColorImage()
                            {
                                ProductColorID = 1, 
                                Name = "", 
                                PathImage = ""
                            }
                        },
                        ProductColorSizes = new List<ProductColorSize>()
                        {
                            new ProductColorSize(){ProductColorID = 1, Name = "M", Quantity = 0 },
                            new ProductColorSize(){ProductColorID = 1, Name = "L", Quantity = 0 },
                            new ProductColorSize(){ProductColorID = 1, Name = "XL", Quantity = 100 },
                            new ProductColorSize(){ProductColorID = 1, Name = "2XL", Quantity = 20 }
                        }
                    },
                    new ProductColor()
                    {
                        Name = "",
                        PathImage = "",
                        ProductID = 1,
                        ProductColorImages = new List<ProductColorImage>()
                        {
                            new ProductColorImage()
                            {
                                ProductColorID = 1, 
                                Name = "", 
                                PathImage = "" 
                            },
                            new ProductColorImage()
                            {
                                ProductColorID = 1, 
                                Name = "", 
                                PathImage = "" 
                            }
                        },
                        ProductColorSizes = new List<ProductColorSize>()
                        {
                            new ProductColorSize(){ProductColorID = 1, Name = "M", Quantity = 2 },
                            new ProductColorSize(){ProductColorID = 1, Name = "L", Quantity = 0 },
                            new ProductColorSize(){ProductColorID = 1, Name = "XL", Quantity = 1 },
                            new ProductColorSize(){ProductColorID = 1, Name = "2XL", Quantity = 0 }
                        }
                    }
                }
            }*/
        );
        modelBuilder.Entity<Rate>().HasData(
            new Rate() {ID = 1, ProductID = 1, Point = 5, Status = RateStatus.Approved, Content = "Good" },
            new Rate() {ID = 2, ProductID = 1, Point = 1, Status = RateStatus.Approved, Content = "Bad" },
            new Rate() {ID = 3, ProductID = 1, Point = 3, Status = RateStatus.Pending, Content = "Good" },
            new Rate() {ID = 4, ProductID = 1, Point = 4, Status = RateStatus.Deleted, Content = "Good" }
        );
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

                    }, new ProductColor()
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
                        ProductID = 1,
                    }


        );

        modelBuilder.Entity<ProductColorImage>().HasData(
new ProductColorImage()
{ID = 1,
    ProductColorID = 1,
    Name = "",
    PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/den_tich_hop.jpg"
},
                            new ProductColorImage()
                            {ID = 2,
                                ProductColorID = 1,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/anh_4_nen_.jpg"
                            },
                            new ProductColorImage()
                            {ID = 3,
                                ProductColorID = 1,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/anh_2_nen.jpg"
                            },
                            new ProductColorImage()
                            {ID = 4,
                                ProductColorID = 1,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/fix.jpg"
                            },
                            new ProductColorImage()
                            {ID = 5,
                                ProductColorID = 1,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/anh_5_nen.jpg"
                            },
                            new ProductColorImage()
                            {ID = 6,
                                ProductColorID = 1,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/anh_6_nen.jpg"
                            }, new ProductColorImage()
                            {ID = 7,
                                ProductColorID = 1,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/utich_hssop_FS-2.jpg"
                            },
                            new ProductColorImage()
                            {ID = 8,
                                ProductColorID = 1,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/2_87.jpg"
                            },
                            new ProductColorImage()
                            {ID = 9,
                                ProductColorID = 1,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/1_79.jpg"
                            },
                            new ProductColorImage()
                            {ID = 10,
                                ProductColorID = 1,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/face3_73.jpg"
                            },
                            new ProductColorImage()
                            {ID = 11,
                                ProductColorID = 1,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/4_6.jpg"
                            },
                            new ProductColorImage()
                            {ID = 12,
                                ProductColorID = 3,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/IMG_6130_91.jpg"
                            },
                            new ProductColorImage()
                            {ID = 13,
                                ProductColorID = 3,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/denn3-(2).jpg"
                            },
                            new ProductColorImage()
                            {ID = 14,
                                ProductColorID = 3,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/comb2_64.jpg"
                            },
                            new ProductColorImage()
                            {ID = 15,
                                ProductColorID = 3,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/MEM_MAI_(11)_(2).jpg"
                            },
                            new ProductColorImage()
                            {ID = 16,
                                ProductColorID = 3,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/1-5_39.jpg"
                            },
                            new ProductColorImage()
                            {ID = 17,
                                ProductColorID = 4,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/IMG_59801u.jpg"
                            },
                            new ProductColorImage()
                            {ID = 18,
                                ProductColorID = 4,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/1white.jpg"
                            },
                            new ProductColorImage()
                            {ID = 19,
                                ProductColorID = 4,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/IMG_6043.jpg"
                            },
                            new ProductColorImage()
                            {ID = 20,
                                ProductColorID = 4,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/IMG_6048.jpg"
                            },
                            new ProductColorImage()
                            {ID = 21,
                                ProductColorID = 4,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/3-111.jpg"
                            },
                            new ProductColorImage()
                            {ID = 22,
                                ProductColorID = 5,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/navy56_74-2_copy.jpg"
                            },
                            new ProductColorImage()
                            {ID = 23,
                                ProductColorID = 5,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/blue.jpg"
                            },
                            new ProductColorImage()
                            {ID = 24,
                                ProductColorID = 5,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/IMG_5855_74_copy.jpg"
                            },
                            new ProductColorImage()
                            {ID = 25,
                                ProductColorID = 5,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/IMG_5878_copy.jpg"
                            },
                            new ProductColorImage()
                            {ID = 26,
                                ProductColorID = 6,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/xamkso_13.jpg"
                            },
                            new ProductColorImage()
                            {ID = 27,
                                ProductColorID = 6,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/1grey.jpg"
                            },
                            new ProductColorImage()
                            {ID = 28,
                                ProductColorID = 6,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/IMG_6248.jpg"
                            },
                            new ProductColorImage()
                            {ID = 29,
                                ProductColorID = 6,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/IMG_6269.jpg"
                            },
                            new ProductColorImage()
                            {ID = 30,
                                ProductColorID = 6,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/IMG_6288.jpg"
                            },
                            new ProductColorImage()
                            {ID = 31,
                                ProductColorID = 6,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/2-1_(3)_(1).jpg"
                            }, new ProductColorImage()
                            {ID = 32,
                                ProductColorID = 7,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/acompax7.jpg"
                            },
                            new ProductColorImage()
                            {ID = 33,
                                ProductColorID = 7,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/penc.jpg"
                            },
                            new ProductColorImage()
                            {ID = 34,
                                ProductColorID = 7,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/compc2_13.jpg"
                            },
                            new ProductColorImage()
                            {ID = 35,
                                ProductColorID = 8,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/compax1.jpg"
                            },
                            new ProductColorImage()
                            {ID = 36,
                                ProductColorID = 8,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/bluelam.jpg"
                            },
                            new ProductColorImage()
                            {ID = 37,
                                ProductColorID = 8,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/DAI04411u.jpg"
                            },
                            new ProductColorImage()
                            {ID = 38,
                                ProductColorID = 8,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/DAI04428_(1).jpg"
                            },
                            new ProductColorImage()
                            {ID = 39,
                                ProductColorID = 8,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/6-0_(5)_(1)_86.jpg"
                            },
                            new ProductColorImage()
                            {ID = 40,
                                ProductColorID = 8,
                                Name = "",
                                PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/November2021/6-2_(2).jpg"
                            }
        );
        modelBuilder.Entity<ProductColorSize>().HasData(
                            new ProductColorSize() { ID = 1, ProductColorID = 1, Name = "M", Quantity = 0 },
                            new ProductColorSize() { ID = 2, ProductColorID = 1, Name = "L", Quantity = 0 },
                            new ProductColorSize() { ID = 3, ProductColorID = 1, Name = "XL", Quantity = 100 },
                            new ProductColorSize() { ID = 4, ProductColorID = 1, Name = "2XL", Quantity = 20 },
                            new ProductColorSize() { ID = 5, ProductColorID = 1, Name = "M", Quantity = 2 },
                            new ProductColorSize() { ID = 6, ProductColorID = 1, Name = "L", Quantity = 0 },
                            new ProductColorSize() { ID = 7, ProductColorID = 1, Name = "XL", Quantity = 1 },
                            new ProductColorSize() { ID = 8, ProductColorID = 1, Name = "2XL", Quantity = 0 },
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
        // modelBuilder.Entity<Rate>().HasData();

    }
}