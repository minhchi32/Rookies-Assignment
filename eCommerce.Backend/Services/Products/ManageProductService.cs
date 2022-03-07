namespace eCommerce.Backend.Services.Products;
public class ManageProductService : IManageProductService
{
    readonly eCommerceContext context;
    public ManageProductService(eCommerceContext context)
    {
        this.context = context;
    }

    public async Task<bool> AddPointRate(int id, int pointRate)
    {
        var product = await context.Products.FirstOrDefaultAsync(x => x.ID == id);
        if (product == null) return false;
        product.TotalPointRate += pointRate;
        product.CountRate++;
        context.Products.Update(product);
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<bool> AddQuantitySale(int id)
    {
        var product = await context.Products.FindAsync(id);
        if (product == null) throw new NullReferenceException(MessageConstants.ProductNotExistID + id);

        product.QuantitySale++;
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<int> Create(ProductCreateRequest request)
    {
        var product = new Product()
        {
            Name = request.Name,
            Description = request.Description,
            Price = request.Price,
            DecreasedPrice = request.DecreasedPrice,
            CategoryID = request.CategoryID,
            SeoTitle = request.SeoTitle,
            SeoDescription = request.SeoDescription,
        };
        context.Products.Add(product);
        await context.SaveChangesAsync();
        return product.ID;
    }

    public async Task<int> Delete(int id)
    {
        var product = await context.Products.FindAsync(id);
        if (product == null) throw new NullReferenceException(MessageConstants.ProductNotExistID + id);
        product.DeletedAt = DateTime.Now;
        product.Status = Status.Deleted;
        context.Products.Update(product);
        return await context.SaveChangesAsync();
    }

    public async Task<PagedResultDTO<ProductVM>> GetAllPaging(GetProductPagingRequest request)
    {
        var query = await context.Products.ToListAsync();
        if (request.CategoryID.HasValue && request.CategoryID > 0)
            query = query.Where(x => x.CategoryID == request.CategoryID).ToList();
        if (!String.IsNullOrEmpty(request.Keyword))
            query = query.Where(x => x.Name.ToLower().Contains(request.Keyword.ToLower())).ToList();

        int totalRow = query.Count();
        var data = query.Skip((request.PageIndex - 1) * request.PageSize)
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
                            SeoDescription = x.SeoDescription,
                            QuantitySale = x.QuantitySale,
                            TotalPointRate = x.TotalPointRate,
                            CountRate = x.CountRate,
                            ProductColors = context.ProductColors.Where(pc => pc.ProductID == x.ID)
                                                                .Select(pc => new ProductColorVM()
                                                                {
                                                                    ID = pc.ID,
                                                                    Name = pc.Name,
                                                                    PathImage = pc.PathImage,
                                                                    ProductID = x.ID,
                                                                    ProductColorImages = null,
                                                                    ProductColorSizes = null,
                                                                }).ToList(),
                        })
                        .ToList();

        var pagedResult = new PagedResultDTO<ProductVM>()
        {
            TotalRecord = totalRow,
            Items = data
        };
        return pagedResult;
    }

    public async Task<ProductVM> GetByID(int id, int colorID = 0)
    {
        var product = await context.Products.FindAsync(id);
        if (product != null)
        {
            var productColor = colorID == 0 ? null : await context.ProductColors
                                                            .Where(x => x.ProductID == product.ID)
                                                            .Select(pc => new ProductColorVM()
                                                            {
                                                                ID = pc.ID,
                                                                Name = pc.Name,
                                                                PathImage = pc.PathImage,
                                                                ProductID = product.ID,
                                                                ProductColorImages = null,
                                                                ProductColorSizes = null,
                                                            }
                                                            ).ToListAsync();
            return new ProductVM()
            {
                ID = product.ID,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                DecreasedPrice = product.DecreasedPrice,
                CategoryID = product.CategoryID,
                SeoTitle = product.SeoTitle,
                SeoDescription = product.SeoDescription,
                QuantitySale = product.QuantitySale,
                TotalPointRate = product.TotalPointRate,
                CountRate = product.CountRate,
                ProductColors = productColor,
            };
        }
        return null;
    }

    public async Task<int> Update(ProductUpdateRequest request)
    {
        var product = await context.Products.FindAsync(request.ID);
        if (product == null) throw new NullReferenceException(MessageConstants.ProductNotExistID + request.ID);

        product.Name = request.Name;
        product.Description = request.Description;
        product.Price = request.Price;
        product.DecreasedPrice = request.DecreasedPrice;
        product.CategoryID = request.CategoryID;
        product.SeoTitle = request.SeoTitle;
        product.SeoDescription = request.SeoDescription;
        product.Status = request.Status;
        product.ModifiedAt = DateTime.Now;
        context.Products.Update(product);

        return await context.SaveChangesAsync();
    }
}