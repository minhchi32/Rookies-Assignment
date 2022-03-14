namespace eCommerce.Backend.Services.Rates;
public class RateService : IRateService
{
    readonly eCommerceContext context;
    public RateService(eCommerceContext context)
    {
        this.context = context;
    }

    public async Task<int> Create(RateCreateRequest request)
    {
        var rate = new Rate()
        {
            ProductID = request.ProductID,
            Point = request.Point,
            Content = request.Content,
            UserID = request.UserID,
            Status = RateStatus.Approved,
        };
        context.Rates.Add(rate);
        await context.SaveChangesAsync();
        return rate.ID;
    }

    public async Task<int> Delete(int rateID)
    {
        var rate = await context.Rates.FindAsync(rateID);
        if (rate == null)
            throw new NullReferenceException(MessageConstants.RateNotExistID + rateID);
        rate.Status = RateStatus.Deleted;
        context.Rates.Update(rate);
        return await context.SaveChangesAsync();
    }

    public async Task<PagedResult<RateVM>> GetAllPaging(GetRatePagingRequest request)
    {
        var query = await context.Rates.Where(x => x.Status == RateStatus.Approved).ToListAsync();

        int totalRow = query.Count();
        var data = query.Skip((request.PageIndex - 1) * request.PageSize)
                        .Take(request.PageSize)
                        .Select(x => new RateVM()
                        {
                            ProductID = x.ProductID,
                            Point = x.Point,
                            Content = x.Content,
                            UserID = x.UserID,
                        })
                        .ToList();

        var pagedResult = new PagedResult<RateVM>()
        {
            TotalRecord = totalRow,
            PageIndex = request.PageIndex,
            PageSize = request.PageSize,
            Items = data
        };
        return pagedResult;
    }

    public async Task<RateVM> GetByID(int rateID)
    {
        var rate = await context.Rates.FindAsync(rateID);
        if (rate != null)
            return new RateVM()
            {
                ProductID = rate.ProductID,
                Point = rate.Point,
                Content = rate.Content,
                UserID = rate.UserID,
            };
        return null;
    }

    public async Task<int> Update(RateUpdateRequest request)
    {
        var rate = await context.Rates.FindAsync(request.ID);
        if (rate == null)
            throw new NullReferenceException(MessageConstants.ProductNotExistID + request.ID);

        rate.Status = request.Status;
        context.Rates.Update(rate);

        return await context.SaveChangesAsync();
    }


    public async Task<List<RateVM>> GetAllRate(int productID)
    {
        var rate = await context.Rates.Where(x => x.ProductID == productID)
                                        .Select(x => new RateVM()
                                        {
                                            ProductID = x.ProductID,
                                            Point = x.Point,
                                            Content = x.Content,
                                            UserID = x.UserID,
                                            AppUser = context.AppUsers.Where(y=>y.Id==x.UserID).FirstOrDefault(),
                                        })
                                        .ToListAsync();
        
        return rate;
    }
}