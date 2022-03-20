using eCommerce.Backend.ViewModel.Products;
using eCommerce.CustomerSite.Service.Products;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.CustomerSite.Controllers;

public class ProductController : Controller
{
    readonly IProductService productService;

    public ProductController(IProductService productService)
    {
        this.productService = productService;
    }

    public async Task<IActionResult> Index(int pageIndex = 1, int pageSize = 2, int categoryID = 0)
    {
        var request = new GetProductPagingRequest()
        {
            PageIndex = pageIndex,
            PageSize = pageSize,
            CategoryID = categoryID,
        };
        var product = await productService.GetAllByCategoryID(request);

        if (product != null)
            System.Diagnostics.Debug.WriteLine(product);
        else
            System.Diagnostics.Debug.WriteLine("product");
            
        ViewBag.Message = product.TotalRecord > 0 ? $"Tìm thấy {product.Items.Count()} sản phẩm" : "Không tìm thấy sản phẩm";
        return View(product);
    }
    public async Task<IActionResult> Detail(int productID, int colorID)
    {
        var product = await productService.ProductDetail(productID, colorID);
        ViewBag.rating = "";
        return View(product);
    }
}
