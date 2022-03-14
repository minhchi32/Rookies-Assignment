using eCommerce.Backend.ViewModel.Products;
using eCommerce.Backend.ViewModel.Rates;
using eCommerce.CustomerSite.Service.Products;
using eCommerce.CustomerSite.Service.Rates;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.CustomerSite.Controllers;

public class RateController : Controller
{
    readonly IRateService rateService;

    public RateController(IRateService rateService)
    {
        this.rateService = rateService;
    }
    public async Task<IActionResult> Index(int productID, int pageIndex = 1, int pageSize = 2)
    {
        var request = new GetRatePagingRequest(){
            PageIndex =pageIndex,
            PageSize = pageSize,
            ProductID = productID
        };
        var rate = await rateService.GetAllPaging(request);
        return View(rate);
    }
    public async Task<IActionResult> Index(int productID)
    {
        var rate = await rateService.GetAllRate(productID);
        return View(rate);
    }
}
