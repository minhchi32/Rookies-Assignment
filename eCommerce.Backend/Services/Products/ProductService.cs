namespace eCommerce.Backend.Services.Products;
public class ProductService : IProductService
{
    readonly eCommerceContext context;
    public ProductService(eCommerceContext context)
    {
        this.context = context;
    }

    public async Task<bool> AddPointRate(int productID, int pointRate)
    {
        var product = await context.Products.FirstOrDefaultAsync(x => x.ID == productID);
        if (product == null) return false;
        product.TotalPointRate += pointRate;
        product.CountRate++;
        context.Products.Update(product);
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<bool> AddQuantitySale(int productID)
    {
        var product = await context.Products.FindAsync(productID);
        if (product == null)
            throw new NullReferenceException(MessageConstants.ProductNotExistID + productID);

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
        };
        context.Products.Add(product);
        await context.SaveChangesAsync();
        return product.ID;
    }

    public async Task<int> Delete(int productID)
    {
        var product = await context.Products.FindAsync(productID);
        if (product == null)
            throw new NullReferenceException(MessageConstants.ProductNotExistID + productID);
        product.DeletedAt = DateTime.Now;
        product.Status = Status.Deleted;
        context.Products.Update(product);
        return await context.SaveChangesAsync();
    }

    public async Task<PagedResult<ProductVM>> GetAllPaging(GetProductPagingRequest request)
    {
        var query = await context.Products.Where(x => x.Status == Status.Show).ToListAsync();

        if (request.CategoryID.HasValue && request.CategoryID > 0)
            query = query.Where(x => x.CategoryID == request.CategoryID).ToList();

        // if (!String.IsNullOrEmpty(request.Keyword))
        //     query = query.Where(x => x.Name.ToLower().Contains(request.Keyword.ToLower())).ToList();

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
                            QuantitySale = x.QuantitySale,
                            TotalPointRate = x.TotalPointRate,
                            CountRate = x.CountRate,
                            ProductColors = context.ProductColors
                                                .Where(pc => pc.ProductID == x.ID && x.Status == Status.Show)
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

        var pagedResult = new PagedResult<ProductVM>()
        {
            TotalRecord = totalRow,
            PageIndex = request.PageIndex,
            PageSize = request.PageSize,
            Items = data
        };
        return pagedResult;
    }

    public async Task<ProductVM> GetByID(int productID, int colorID = 0)
    {
        var product = await context.Products.FindAsync(productID);
        if (product != null)
        {
            var productColor = colorID == 0 ? null : await context.ProductColors
                                                            .Where(x => x.ProductID == product.ID && x.Status == Status.Show)
                                                            .Include(x => x.ProductColorImages)
                                                            .Include(x => x.ProductColorSizes)
                                                            .Select(pc => new ProductColorVM()
                                                            {
                                                                ID = pc.ID,
                                                                Name = pc.Name,
                                                                PathImage = pc.PathImage,
                                                                ProductID = product.ID,
                                                                ProductColorImages = pc.ProductColorImages.Select(pci => new ProductColorImageVM()
                                                                {
                                                                    ID = pci.ID,
                                                                    Name = pci.Name,
                                                                    PathImage = pci.PathImage,
                                                                    ProductColorID = pci.ProductColorID,
                                                                }).ToList(),
                                                                ProductColorSizes = pc.ProductColorSizes.Select(pcs => new ProductColorSizeVM()
                                                                {
                                                                    ID = pcs.ID,
                                                                    Name = pcs.Name,
                                                                    Quantity = pcs.Quantity,
                                                                    ProductColorID = pcs.ProductColorID,
                                                                }).ToList(),
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
        if (product == null)
            throw new NullReferenceException(MessageConstants.ProductNotExistID + request.ID);

        product.Name = request.Name;
        product.Description = request.Description;
        product.Price = request.Price;
        product.DecreasedPrice = request.DecreasedPrice;
        product.CategoryID = request.CategoryID;
        product.SeoTitle = request.SeoTitle;
        product.Status = request.Status;
        product.ModifiedAt = DateTime.Now;
        context.Products.Update(product);

        return await context.SaveChangesAsync();
    }
    public async Task<List<ProductVM>> GetAll()
    {
        var result = await context.Products.Where(x => x.Status == Status.Show)
                                            .Include(x => x.ProductColors)
                                            .ThenInclude(x => x.ProductColorImages)
                                            .Include(x => x.ProductColors)
                                            .ThenInclude(x => x.ProductColorSizes)
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
                                                ProductColorImages = pc.ProductColorImages.Select(pci => new ProductColorImageVM()
                                                {
                                                    ID = pci.ID,
                                                    Name = pci.Name,
                                                    PathImage = pci.PathImage,
                                                    ProductColorID = pci.ProductColorID,
                                                }).ToList(),
                                                ProductColorSizes = pc.ProductColorSizes.Select(pcs => new ProductColorSizeVM()
                                                {
                                                    ID = pcs.ID,
                                                    Name = pcs.Name,
                                                    Quantity = pcs.Quantity,
                                                    ProductColorID = pcs.ProductColorID,
                                                }).ToList(),
                                            }).ToList(),
        }).ToList();

        return data;
    }

    public async Task<PagedResult<ProductVM>> GetAllByCategoryID(GetProductPagingRequest request)
    {
        var result = await context.Products.Where(x => x.Status == Status.Show)
                                            .Include(x => x.ProductColors)
                                            .ThenInclude(x => x.ProductColorImages)
                                            .Include(x => x.ProductColors)
                                            .ThenInclude(x => x.ProductColorSizes)
                                            .ToListAsync();
        // var query = await context.Products.Where(x => x.Status == Status.Show).ToListAsync();
        if (request.CategoryID.HasValue && request.CategoryID > 0)
            result = result.Where(x => x.CategoryID == request.CategoryID).ToList();

        // var result = await context.Products.Include(x => x.ProductColors).ToListAsync();
        // result = result.Where(x => query.Any(y => y.ID == x.ID)).ToList();
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
            ProductColors = x.ProductColors.Where(x => x.Status == Status.Show)
                                            .Select(pc => new ProductColorVM()
                                            {
                                                ID = pc.ID,
                                                Name = pc.Name,
                                                PathImage = pc.PathImage,
                                                ProductID = x.ID,
                                                ProductColorImages = pc.ProductColorImages.Select(pci => new ProductColorImageVM()
                                                {
                                                    ID = pci.ID,
                                                    Name = pci.Name,
                                                    PathImage = pci.PathImage,
                                                    ProductColorID = pci.ProductColorID,
                                                }).ToList(),
                                                ProductColorSizes = pc.ProductColorSizes.Select(pcs => new ProductColorSizeVM()
                                                {
                                                    ID = pcs.ID,
                                                    Name = pcs.Name,
                                                    Quantity = pcs.Quantity,
                                                    ProductColorID = pcs.ProductColorID,
                                                }).ToList(),
                                            }).ToList(),
        }).ToList();

        var pagedResult = new PagedResult<ProductVM>()
        {
            TotalRecord = totalRow,
            PageIndex = request.PageIndex,
            PageSize = request.PageSize,
            Items = data
        };
        return pagedResult;
    }

    public async Task<List<ProductVM>> Get4Product()
    {
        var result = await context.Products.Where(x => x.Status == Status.Show)
                                            .Include(x => x.ProductColors)
                                            .ThenInclude(x => x.ProductColorImages)
                                            .Include(x => x.ProductColors)
                                            .ThenInclude(x => x.ProductColorSizes)
                                            .Take(4)
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
                                                ProductColorImages = pc.ProductColorImages.Select(pci => new ProductColorImageVM()
                                                {
                                                    ID = pci.ID,
                                                    Name = pci.Name,
                                                    PathImage = pci.PathImage,
                                                    ProductColorID = pci.ProductColorID,
                                                }).ToList(),
                                                ProductColorSizes = pc.ProductColorSizes.Select(pcs => new ProductColorSizeVM()
                                                {
                                                    ID = pcs.ID,
                                                    Name = pcs.Name,
                                                    Quantity = pcs.Quantity,
                                                    ProductColorID = pcs.ProductColorID,
                                                }).ToList(),
                                            }).ToList(),
        }).ToList();

        return data;
    }
}