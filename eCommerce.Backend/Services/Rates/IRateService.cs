namespace eCommerce.Backend.Services.Rates;
public interface IRateService
{
    Task<int> Create(RateCreateRequest request);
    Task<int> Update(RateUpdateRequest request);
    Task<int> Delete(int id);
    Task<RateVM> GetByID(int rateID);
    Task<List<RateVM>> GetAllRate(int productID);
    Task<PagedResult<RateVM>> GetAllPaging(GetRatePagingRequest request);
}