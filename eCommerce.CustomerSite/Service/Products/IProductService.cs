using eCommerce.Backend.ViewModel.Products;
using eCommerce.Shared.DTO;

namespace eCommerce.CustomerSite.Service.Products;
public interface IProductService
{

    Task<List<ProductVM>> Get4Product();

    Task<PagedModelDTO<ProductVM>> GetAllByCategoryID(GetProductPagingRequest request);
    Task<ProductVM> ProductDetail(int productID, int colorID);
}