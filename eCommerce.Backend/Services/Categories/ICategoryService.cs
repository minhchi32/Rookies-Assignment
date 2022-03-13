namespace eCommerce.Backend.Services.Categories;
public interface ICategoryService
{
    Task<int> Create(CategoryCreateRequest request);
    Task<int> Update(CategoryUpdateRequest request);
    Task<int> Delete(int id);
    Task<CategoryVM> GetByID(int id);
    Task<List<CategoryVM>> GetAll();
    Task<PagedResult<ProductVM>> GetListProductCategoryID(GetProductPagingRequest request);
}