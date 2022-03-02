namespace eCommerce.Backend.Services.Products;
public interface IManageProductService
{
    Task<int> Create(ProductCreateRequest request);
    Task<int> Update(ProductUpdateRequest request);
    Task<int> Delete(int id);
    Task<ProductViewDTO> GetByID(int id);
    Task<bool> AddQuantitySale(int id);
    Task<bool> AddPointRate(int id, int pointRate);
    Task<PagedResultDTO<ProductViewDTO>> GetAllPaging(GetProductPagingRequest request);
}