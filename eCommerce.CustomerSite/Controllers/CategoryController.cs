using eCommerce.CustomerSite.Service.Categories;
using eCommerce.Shared.DTO;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.CustomerSite.Controllers;

public class CategoryController : Controller
{
    readonly ICategoryService categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        this.categoryService = categoryService;
    }

    public async Task<IActionResult> Index()
    {
        return View();
    }
    public async Task<IActionResult> GetAllCategory()
    {
        var product = await categoryService.GetAll();
        return View(product);
    }
}
