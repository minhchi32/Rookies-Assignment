namespace eCommerce.Backend.Services.Products;
public interface IPublicProductService
{
    Task<PagedResultDTO<ProductViewDTO>> GetAllByCategoryID(GetProductPagingRequest request);
}