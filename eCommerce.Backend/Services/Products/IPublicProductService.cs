namespace eCommerce.Backend.Services.Products;
public interface IPublicProductService
{
    Task<PagedResultDTO<ProductVM>> GetAllByCategoryID(GetProductPagingRequest request);
    Task<List<ProductVM>> GetAll();
}