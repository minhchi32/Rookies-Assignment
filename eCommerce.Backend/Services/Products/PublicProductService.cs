namespace eCommerce.Backend.Services.Products;
public class PublicProductService : IPublicProductService
{
    readonly eCommerceContext context;
    public PublicProductService(eCommerceContext context)
    {
        this.context = context;
    }

    public async Task<PagedResultDTO<ProductViewDTO>> GetAllByCategoryID(GetProductPagingRequest request)
    {
        var query = await context.Products.ToListAsync();
        if (request.CategoryID.HasValue && request.CategoryID > 0)
            query = query.Where(x => x.CategoryID == request.CategoryID).ToList();

        var result = from p in query
                     join pc in context.ProductColors on p.ID equals pc.ProductID
                     join pcs in context.ProductColorSizes on pc.ID equals pcs.ProductColorID
                     join pci in context.ProductColorImages on pc.ID equals pci.ProductColorID
                     select new { p, pc, pcs, pci };

        int totalRow = result.Count();
        var data = result.Skip((request.PageIndex - 1) * request.PageSize)
                        .Take(request.PageSize)
                        .Select(x => new ProductViewDTO()
                        {
                            ID = x.p.ID,
                            Name = x.p.Name,
                            Description = x.p.Description,
                            Price = x.p.Price,
                            DecreasedPrice = x.p.DecreasedPrice,
                            CategoryID = x.p.CategoryID,
                            SeoTitle = x.p.SeoTitle,
                            SeoDescription = x.p.SeoDescription,
                            QuantitySale = x.p.QuantitySale,
                            TotalPointRate = x.p.TotalPointRate,
                            CountRate = x.p.CountRate,
                        })
                        .ToList();

        var pagedResult = new PagedResultDTO<ProductViewDTO>()
        {
            TotalRecord = totalRow,
            Items = data
        };
        return pagedResult;
    }
}