using System.Diagnostics;
using eCommerce.CustomerSite.Models;
using eCommerce.CustomerSite.Service.Products;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.CustomerSite.Controllers;

public class HomeController : Controller
{
    readonly IProductService productService;

    public HomeController(IProductService productService)
    {
        this.productService = productService;
    }

    public async Task<IActionResult> Index()
    {
        var product = await productService.Get4Product();
        return View(product);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
