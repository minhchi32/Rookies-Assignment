using eCommerce.Backend.ViewModel.Rates;
using eCommerce.Shared.DTO;

namespace eCommerce.CustomerSite.Service.Rates;
public interface IRateService
{

    Task<bool> Create(RateCreateRequest request);
    Task<RateVM> GetByID(int rateID);
    Task<PagedModelDTO<RateVM>> GetAllPaging(GetRatePagingRequest request);
    Task<List<RateVM>> GetAllRate(int productID);
}