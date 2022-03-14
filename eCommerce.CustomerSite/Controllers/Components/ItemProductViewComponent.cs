using eCommerce.Backend.ViewModel.Products;
using eCommerce.Shared.DTO;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.CustomerSite.Controllers.Components
{
    public class ItemProductViewComponent: ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(List<ProductVM> result)
        {
            return Task.FromResult((IViewComponentResult)View("Default", result));
        }
    }
}
