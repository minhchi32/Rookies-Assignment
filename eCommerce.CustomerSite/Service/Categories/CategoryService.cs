using eCommerce.Backend.ViewModel.Categories;
using eCommerce.Backend.ViewModel.Products;
using eCommerce.Shared.Constants;
using eCommerce.Shared.DTO;
using Newtonsoft.Json;

namespace eCommerce.CustomerSite.Service.Categories;
public class CategoryService : ICategoryService
{
    readonly IHttpClientFactory clientFactory;

    readonly IConfiguration configuration;
    public CategoryService(IHttpClientFactory clientFactory, IConfiguration configuration)
    {
        this.clientFactory = clientFactory;
        this.configuration = configuration;
    }

    public async Task<List<CategoryVM>> GetAll()
    {
        var client = clientFactory.CreateClient();
        client.BaseAddress = new Uri(configuration[ConfigurationConstants.BackendEndPoint]);
        var response = await client.GetAsync("/api/Categories/all");
        var body = await response.Content.ReadAsStringAsync();
        var categories = JsonConvert.DeserializeObject<List<CategoryVM>>(body);
        return categories;
    }

    public Task<CategoryVM> GetByID(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<PagedModelDTO<ProductVM>> GetListProductCategoryID(GetProductPagingRequest request)
    {
        var client = clientFactory.CreateClient();
        client.BaseAddress = new Uri(configuration[ConfigurationConstants.BackendEndPoint]);
        var response = await client.GetAsync($"/api/Categories/paging?PageIndex={request.PageIndex}&PageSize={request.PageSize}&CategoryID={request.CategoryID}");
        var body = await response.Content.ReadAsStringAsync();
        var products = JsonConvert.DeserializeObject<PagedModelDTO<ProductVM>>(body);
        return products;
    }
}