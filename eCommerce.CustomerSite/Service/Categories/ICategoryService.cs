using eCommerce.Backend.ViewModel.Categories;
using eCommerce.Backend.ViewModel.Products;
using eCommerce.Shared.DTO;

namespace eCommerce.CustomerSite.Service.Categories;
public interface ICategoryService
{
    Task<CategoryVM> GetByID(int id);
    Task<List<CategoryVM>> GetAll();
    Task<PagedModelDTO<ProductVM>> GetListProductCategoryID(GetProductPagingRequest request);
}