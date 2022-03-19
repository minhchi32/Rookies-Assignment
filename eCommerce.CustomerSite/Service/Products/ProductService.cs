using eCommerce.Backend.ViewModel.Products;
using eCommerce.Shared.Constants;
using eCommerce.Shared.DTO;
using Newtonsoft.Json;

namespace eCommerce.CustomerSite.Service.Products;
public class ProductService : IProductService
{
    readonly IHttpClientFactory clientFactory;

    readonly IConfiguration configuration;
    public ProductService(IHttpClientFactory clientFactory, IConfiguration configuration)
    {
        this.clientFactory = clientFactory;
        this.configuration = configuration;
    }

    public async Task<List<ProductVM>> Get4Product()
    {
        var client = clientFactory.CreateClient();
        client.BaseAddress = new Uri(configuration[ConfigurationConstants.BackendEndPoint]);
        var response = await client.GetAsync("/api/Products/get4product");
        var body = await response.Content.ReadAsStringAsync();
        var products = JsonConvert.DeserializeObject<List<ProductVM>>(body);
        return products;
    }

    public async Task<PagedModelDTO<ProductVM>> GetAllByCategoryID(GetProductPagingRequest request)
    {
        var client = clientFactory.CreateClient();
        client.BaseAddress = new Uri(configuration[ConfigurationConstants.BackendEndPoint]);
        var response = await client.GetAsync($"/api/Products/paging?PageIndex={request.PageIndex}&PageSize={request.PageSize}&CategoryID={request.CategoryID}");
        var body = await response.Content.ReadAsStringAsync();
        var products = JsonConvert.DeserializeObject<PagedModelDTO<ProductVM>>(body);
        return products;

    }

    public async Task<ProductVM> ProductDetail(int productID, int colorID)
    {
        var client = clientFactory.CreateClient();
        client.BaseAddress = new Uri(configuration[ConfigurationConstants.BackendEndPoint]);
        var response = await client.GetAsync($"/api/Products/{productID}/{colorID}");
        var body = await response.Content.ReadAsStringAsync();
        var product = JsonConvert.DeserializeObject<ProductVM>(body);
        return product;
    }
}