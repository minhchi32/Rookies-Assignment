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
        if (product == null) throw new NullReferenceException($"Không tìm thấy sản phẩm có mã {id}");

        product.QuantitySale++;
        // context.Products.Update(product);
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
        return await context.SaveChangesAsync();
    }

    public async Task<int> Delete(int id)
    {
        var product = await context.Products.FindAsync(id);
        if (product == null) throw new NullReferenceException($"Không tìm thấy sản phẩm có mã {id}");
        product.DeletedAt = DateTime.Now;
        product.Status = Status.Deleted;
        context.Products.Update(product);
        return await context.SaveChangesAsync();
    }

    public async Task<PagedResultDTO<ProductViewDTO>> GetAllPaging(GetProductPagingRequest request)
    {
        var query = await context.Products.ToListAsync();
        if (request.CategoryID.HasValue && request.CategoryID > 0)
            query = query.Where(x => x.CategoryID == request.CategoryID).ToList();
        if (!String.IsNullOrEmpty(request.Keyword))
            query = query.Where(x => x.Name.ToLower().Contains(request.Keyword.ToLower())).ToList();

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

    public async Task<ProductViewDTO> GetByID(int id)
    {
        var product = await context.Products.FindAsync(id);
        if (product != null)
            return new ProductViewDTO()
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
            };
        return null;
    }

    public async Task<int> Update(ProductUpdateRequest request)
    {
        var product = await context.Products.FindAsync(request.ID);
        if (product == null) throw new NullReferenceException($"Không tìm thấy sản phẩm có mã {request.ID}");

        product.Name = request.Name;
        product.Description = request.Description;
        product.Price = request.Price;
        product.DecreasedPrice = request.DecreasedPrice;
        product.CategoryID = request.CategoryID;
        product.SeoTitle = request.SeoTitle;
        product.SeoDescription = request.SeoDescription;
        product.Status = request.Status;
        product.ModifiedAt = DateTime.Now;

        return await context.SaveChangesAsync();
    }
}