namespace eCommerce.Backend.Services.Products;
public interface IManageProductService
{
    Task<int> Create(ProductCreateRequest request);
    Task<int> Update(ProductUpdateRequest request);
    Task<int> Delete(int id);
    Task<ProductVM> GetByID(int productID, int colorID = 0);
    Task<bool> AddQuantitySale(int productID);
    Task<bool> AddPointRate(int productID, int pointRate);
    Task<PagedResultDTO<ProductVM>> GetAllPaging(GetProductPagingRequest request);
}