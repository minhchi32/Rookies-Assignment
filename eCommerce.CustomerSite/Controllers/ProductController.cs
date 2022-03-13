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
        var request = new GetProductPagingRequest(){
            PageIndex =pageIndex,
            PageSize = pageSize,
            CategoryID = categoryID,
        };
        var product = await productService.GetAllByCategoryID(request);
        return View(product);
    }
    public async Task<IActionResult> Index1()
    {
        var product = await productService.Get4Product();
        return View(product);
    }
}
