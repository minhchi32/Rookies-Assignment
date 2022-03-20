namespace eCommerce.Backend.Services.Categories;
public interface ICategoryService
{
    Task<int> Create(CategoryCreateRequest request);
    Task<int> Update(CategoryUpdateRequest request);
    Task<int> Delete(int id);
    Task<CategoryVM> GetByID(int id);
    Task<PagedModelDTO<CategoryVM>> GetAllWithPaging(PagedResultBase request);
    Task<List<CategoryVM>> GetAll();
    Task<IEnumerable<CategoryVM>> GetCategoriesOption(string getParam);
    Task<PagedModelDTO<ProductVM>> GetListProductCategoryID(GetProductPagingRequest request);
}