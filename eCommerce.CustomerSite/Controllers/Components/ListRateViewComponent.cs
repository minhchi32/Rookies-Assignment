using eCommerce.Backend.ViewModel.Rates;
using eCommerce.CustomerSite.Service.Rates;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.CustomerSite.Controllers.Components
{
    public class ListRateViewComponent : ViewComponent
    {
        readonly IRateService rateService;
        public ListRateViewComponent(IRateService rateService)
        {
            this.rateService = rateService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int productID)
        {
            return await Task.FromResult((IViewComponentResult)View("Default",await rateService.GetAllRate(productID)));
        }
    }
}
