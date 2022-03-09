namespace eCommerce.Backend.Services.Products;
public class PublicProductService : IPublicProductService
{
    readonly eCommerceContext context;
    public PublicProductService(eCommerceContext context)
    {
        this.context = context;
    }

    public async Task<List<ProductVM>> GetAll()
    {
        var result = await context.Products.Where(x => x.Status == Status.Show)
                                            .Include(x => x.ProductColors)
                                            .ToListAsync();

        var data = result.Select(x => new ProductVM()
        {
            ID = x.ID,
            Name = x.Name,
            Description = x.Description,
            Price = x.Price,
            DecreasedPrice = x.DecreasedPrice,
            CategoryID = x.CategoryID,
            SeoTitle = x.SeoTitle,
            QuantitySale = x.QuantitySale,
            TotalPointRate = x.TotalPointRate,
            CountRate = x.CountRate,
            ProductColors = x.ProductColors.Where(x => x.Status == Status.Show)
                                            .Select(pc => new ProductColorVM()
                                            {
                                                ID = pc.ID,
                                                Name = pc.Name,
                                                PathImage = pc.PathImage,
                                                ProductID = x.ID,
                                                ProductColorImages = null,
                                                ProductColorSizes = null,
                                            }).ToList(),
        }).ToList();

        return data;
    }

    public async Task<PagedResultDTO<ProductVM>> GetAllByCategoryID(GetProductPagingRequest request)
    {
        var query = await context.Products.Where(x => x.Status == Status.Show).ToListAsync();
        if (request.CategoryID.HasValue && request.CategoryID > 0)
            query = query.Where(x => x.CategoryID == request.CategoryID).ToList();

        var result = await context.Products.Include(x => x.ProductColors).ToListAsync();
        result = result.Where(x => query.Any(y => y.ID == x.ID)).ToList();
        int totalRow = result.Count();
        var data = result.Skip((request.PageIndex - 1) * request.PageSize)
                        .Take(request.PageSize)
                        .Select(x => new ProductVM()
                        {
                            ID = x.ID,
                            Name = x.Name,
                            Description = x.Description,
                            Price = x.Price,
                            DecreasedPrice = x.DecreasedPrice,
                            CategoryID = x.CategoryID,
                            SeoTitle = x.SeoTitle,
                            QuantitySale = x.QuantitySale,
                            TotalPointRate = x.TotalPointRate,
                            CountRate = x.CountRate,
                        })
                        .ToList();

        var pagedResult = new PagedResultDTO<ProductVM>()
        {
            TotalRecord = totalRow,
            Items = data
        };
        return pagedResult;
    }
}