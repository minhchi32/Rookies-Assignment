using eCommerce.CustomerSite.Service.Categories;
using eCommerce.Backend.ViewModel.Categories;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.CustomerSite.Controllers.Components
{
    public class ListCategoryViewComponent : ViewComponent
    {
        readonly ICategoryService categoryService;
        public ListCategoryViewComponent(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("Default",await categoryService.GetAll()));
        }
    }
}
