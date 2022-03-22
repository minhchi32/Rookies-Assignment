using System.Collections.Generic;
using eCommerce.Backend.ViewModel.ProductColorImages;
using eCommerce.Backend.ViewModel.ProductColors;
using eCommerce.Backend.ViewModel.ProductColorSizes;
using eCommerce.Backend.ViewModel.Products;
using eCommerce.Shared.DTO;

namespace eCommerce.UnitTest.BackendApiTesting.Mock.MockData;
public class ProductsMockData
{
    public static ProductVM GetExistProductId()
    {
        return Data();
    }
    public static ProductVM GetNotExistProductId()
    {
        return new ProductVM
        {
            ID = 31,
            Name = "gserg",
            Price = 250000,
            DecreasedPrice = 250000,
            CategoryID = 5,
            QuantitySale = 5,
            TotalPointRate = 5,
            CountRate = 5,
            ProductColors = null
        };
    }
    public static PagedModelDTO<ProductVM> GetAllProductAndPaging()
    {
        return new PagedModelDTO<ProductVM>
        {
            PageIndex = 1,
            PageSize = 1,
            Search = null,
            SortOrder = 0,
            SortColumn = "ID",
            TotalRecord = 2,
            Items = new List<ProductVM>(){
                Data(),
            },
        };
    }
    static ProductVM Data()
    {
        return new ProductVM
        {
            ID = 1,
            Name = "Áo khoác đa năng cản gió và chống UV",
            Price = 499000,
            DecreasedPrice = 399000,
            CategoryID = 4,
            QuantitySale = 970,
            TotalPointRate = 128,
            CountRate = 26,
            ProductColors = new List<ProductColorVM>()
            {
                new ProductColorVM()
                {
                    ID = 1,
                    Name = "Đen",
                    PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/4-4_(1)_80x80.jpg",
                    ProductID = 1,
                    ProductColorImages = new List<ProductColorImageVM>()
                    {
                        new ProductColorImageVM()
                        {
                            ID = 1,
                            ProductColorID = 1,
                            Name = "",
                            PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/den_tich_hop.jpg"
                        },
                        new ProductColorImageVM()
                        {
                            ID = 2,
                            ProductColorID = 1,
                            Name = "",
                            PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/anh_4_nen_.jpg"
                        },
                        new ProductColorImageVM()
                        {
                            ID = 3,
                            ProductColorID = 1,
                            Name = "",
                            PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/anh_2_nen.jpg"
                        },
                        new ProductColorImageVM()
                        {
                            ID = 4,
                            ProductColorID = 1,
                            Name = "",
                            PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/fix.jpg"
                        },
                        new ProductColorImageVM()
                        {
                            ID = 5,
                            ProductColorID = 1,
                            Name = "",
                            PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/anh_5_nen.jpg"
                        },
                        new ProductColorImageVM()
                        {
                            ID = 6,
                            ProductColorID = 1,
                            Name = "",
                            PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/anh_6_nen.jpg"
                        },
                    },
                    ProductColorSizes = new List<ProductColorSizeVM>()
                    {
                        new ProductColorSizeVM() { ID = 1, ProductColorID = 1, Name = "M", Quantity = 0 },
                        new ProductColorSizeVM() { ID = 2, ProductColorID = 1, Name = "L", Quantity = 0 },
                        new ProductColorSizeVM() { ID = 3, ProductColorID = 1, Name = "XL", Quantity = 100 },
                        new ProductColorSizeVM() { ID = 4, ProductColorID = 1, Name = "2XL", Quantity = 20 },
                    }
                },
                new ProductColorVM()
                {
                    ID = 2,
                    Name = "Xanh rêu",
                    PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/7-2_80x80.jpg",
                    ProductID = 1,
                    ProductColorImages = new List<ProductColorImageVM>()
                    {
                        new ProductColorImageVM()
                        {
                            ID = 7,
                            ProductColorID = 2,
                            Name = "",
                            PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/utich_hssop_FS-2.jpg"
                        },
                        new ProductColorImageVM()
                        {
                            ID = 8,
                            ProductColorID = 2,
                            Name = "",
                            PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/2_87.jpg"
                        },
                        new ProductColorImageVM()
                        {
                            ID = 9,
                            ProductColorID = 2,
                            Name = "",
                            PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/1_79.jpg"
                        },
                        new ProductColorImageVM()
                        {
                            ID = 10,
                            ProductColorID = 2,
                            Name = "",
                            PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/face3_73.jpg"
                        },
                        new ProductColorImageVM()
                        {
                            ID = 11,
                            ProductColorID = 2,
                            Name = "",
                            PathImage = "https://mcdn2-coolmate.cdn.vccloud.vn/uploads/December2021/4_6.jpg"
                        },
                    },
                    ProductColorSizes = new List<ProductColorSizeVM>()
                    {
                        new ProductColorSizeVM() { ID = 5, ProductColorID = 2, Name = "M", Quantity = 2 },
                        new ProductColorSizeVM() { ID = 6, ProductColorID = 2, Name = "L", Quantity = 0 },
                        new ProductColorSizeVM() { ID = 7, ProductColorID = 2, Name = "XL", Quantity = 1 },
                        new ProductColorSizeVM() { ID = 8, ProductColorID = 2, Name = "2XL", Quantity = 0 },
                    }

                },
            },
        };
    }
}