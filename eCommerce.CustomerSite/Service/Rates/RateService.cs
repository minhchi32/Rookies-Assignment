using System.Text;
using eCommerce.Backend.ViewModel.Rates;
using eCommerce.CustomerSite.Service.Rates;
using eCommerce.Shared.Constants;
using eCommerce.Shared.DTO;
using Newtonsoft.Json;

namespace eCommerce.CustomerSite.Service.Products;
public class RateService : IRateService
{
    readonly IHttpClientFactory clientFactory;

    readonly IConfiguration configuration;
    public RateService(IHttpClientFactory clientFactory, IConfiguration configuration)
    {
        this.clientFactory = clientFactory;
        this.configuration = configuration;
    }

    public async Task<bool> Create(RateCreateRequest request)
    {
        var client = clientFactory.CreateClient();
        client.BaseAddress = new Uri(configuration[ConfigurationConstants.BackendEndPoint]);
        var requestContent = new MultipartFormDataContent();
        requestContent.Add(new StringContent(request.ProductID.ToString()), "productID");
        requestContent.Add(new StringContent(request.Point.ToString()), "point");
        requestContent.Add(new StringContent(string.IsNullOrEmpty(request.Content) ? "" : request.Content.ToString()), "content");
        requestContent.Add(new StringContent(request.UserID.ToString()), "userID");
        requestContent.Add(new StringContent(request.Status.ToString()), "status");
        requestContent.Add(new StringContent(DateTime.Now.ToString()), "createAt");

        var response = await client.PostAsync($"/api/Rates/", requestContent);
        return response.IsSuccessStatusCode;
    }

    public async Task<List<RateVM>> GetAllRate(int productID)
    {
         var client = clientFactory.CreateClient();
        client.BaseAddress = new Uri(configuration[ConfigurationConstants.BackendEndPoint]);
        var response = await client.GetAsync($"/api/Rates/rating/{productID}");
        var body = await response.Content.ReadAsStringAsync();
        var rates = JsonConvert.DeserializeObject<List<RateVM>>(body);
        return rates;
    }

    public async Task<PagedModelDTO<RateVM>> GetAllPaging(GetRatePagingRequest request)
    {
        var client = clientFactory.CreateClient();
        client.BaseAddress = new Uri(configuration[ConfigurationConstants.BackendEndPoint]);
        var response = await client.GetAsync($"/api/Rates/paging?PageIndex={request.PageIndex}&PageSize={request.PageSize}");
        var body = await response.Content.ReadAsStringAsync();
        var rates = JsonConvert.DeserializeObject<PagedModelDTO<RateVM>>(body);
        return rates;
    }

    public async Task<RateVM> GetByID(int rateID)
    {
        var client = clientFactory.CreateClient();
        client.BaseAddress = new Uri(configuration[ConfigurationConstants.BackendEndPoint]);
        var response = await client.GetAsync($"/api/Rates/{rateID}");
        var body = await response.Content.ReadAsStringAsync();
        var rate = JsonConvert.DeserializeObject<RateVM>(body);
        return rate;
    }
}