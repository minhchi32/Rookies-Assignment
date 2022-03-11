using eCommerce.Shared.DTO;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.CustomerSite.Controllers.Components
{
    public class PagerViewComponent: ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(PagedResultBase result)
        {
            return Task.FromResult((IViewComponentResult)View("Default", result));
        }
    }
}
