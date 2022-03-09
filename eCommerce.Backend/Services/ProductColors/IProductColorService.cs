namespace eCommerce.Backend.Services.ProductColors;
public interface IProductColorService
{
    Task<int> Create(ProductColorCreateRequest request);
    Task<int> Update(ProductColorUpdateRequest request);
    Task<int> Delete(int id);
    Task<List<ProductColorVM>> GetAll();
    Task<ProductColorVM> GetByID(int id);
    Task<List<ProductColorVM>> GetListImage(int id);
}