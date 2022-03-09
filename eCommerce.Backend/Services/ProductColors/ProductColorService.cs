namespace eCommerce.Backend.Services.ProductColors;
public class ProductColorService : IProductColorService
{
    readonly eCommerceContext context;
    readonly IFileStorageService storageService;
    public ProductColorService(eCommerceContext context, IFileStorageService storageService)
    {
        this.context = context;
        this.storageService = storageService;
    }

    public async Task<int> Create(ProductColorCreateRequest request)
    {
        var productColor = new ProductColor()
        {
            Name = request.Name,
            ProductID = request.ProductID,
            CreatedAt = DateTime.Now,
        };
        if (request.PathImage != null)
            productColor.PathImage = await SaveImage(request.PathImage);
        context.ProductColors.Add(productColor);
        await context.SaveChangesAsync();
        return productColor.ID;
    }

    public async Task<int> Delete(int id)
    {
        var productColor = await context.ProductColors.FindAsync(id);
        if (productColor == null)
            throw new NullReferenceException(MessageConstants.ProductNotExistID + id);
        productColor.DeletedAt = DateTime.Now;
        productColor.Status = Status.Deleted;
        context.ProductColors.Update(productColor);
        return await context.SaveChangesAsync();
    }

    public async Task<ProductColorVM> GetByID(int id)
    {
        var productColor = await context.ProductColors.FindAsync(id);
        if (productColor != null)
        {
            var productColorImage = await context.ProductColorImages
                                                .Where(x => x.ProductColorID == productColor.ID)
                                                .Select(pci => new ProductColorImageVM()
                                                {
                                                    ID = pci.ID,
                                                    Name = pci.Name,
                                                    PathImage = pci.PathImage,
                                                    ProductColorID = productColor.ID,
                                                }
                                                ).ToListAsync();
            var productColorSize = await context.ProductColorSizes
                                                .Where(x => x.ProductColorID == productColor.ID)
                                                .Select(pcs => new ProductColorSizeVM()
                                                {
                                                    ID = pcs.ID,
                                                    Name = pcs.Name,
                                                    Quantity = pcs.Quantity,
                                                    ProductColorID = productColor.ID,
                                                }
                                                ).ToListAsync();
            return new ProductColorVM()
            {
                ID = productColor.ID,
                Name = productColor.Name,
                PathImage = productColor.PathImage,
                ProductID = productColor.ProductID,
                ProductColorImages = productColorImage,
                ProductColorSizes = productColorSize,
            };
        }
        return null;
    }

    public async Task<int> Update(ProductColorUpdateRequest request)
    {
        var productColor = await context.ProductColors.FindAsync(request.ID);
        if (productColor == null)
            throw new NullReferenceException(MessageConstants.ProductNotExistID + request.ID);
        if (productColor.PathImage != null)
            productColor.PathImage = await SaveImage(request.PathImage);
        productColor.Name = request.Name;
        productColor.ProductID = request.ProductID;
        productColor.Status = request.Status;
        productColor.ModifiedAt = DateTime.Now;
        context.ProductColors.Update(productColor);

        return await context.SaveChangesAsync();
    }
    public async Task<string> SaveImage(IFormFile file)
    {
        var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
        var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
        await storageService.SaveFileAsync(file.OpenReadStream(), fileName);
        return $"/{FolderConstant.imageFolderName}/{fileName}";
    }

    public async Task<List<ProductColorVM>> GetListImage(int id)
    {
        var result = await context.ProductColors.Where(x => x.ProductID == id && x.Status == Status.Show)
                                                .Include(x => x.ProductColorImages)
                                                .Include(x => x.ProductColorSizes)
                                                .Select(x => new ProductColorVM()
                                                {
                                                    ID = x.ID,
                                                    Name = x.Name,
                                                    PathImage = x.PathImage,
                                                    ProductID = x.ProductID,
                                                    ProductColorImages = x.ProductColorImages
                                                    .Select(pci => new ProductColorImageVM()
                                                    {
                                                        ID = pci.ID,
                                                        Name = pci.Name,
                                                        PathImage = pci.PathImage,
                                                        ProductColorID = x.ID,
                                                    }
                                                    ).ToList(),
                                                    ProductColorSizes = x.ProductColorSizes
                                                    .Select(pcs => new ProductColorSizeVM()
                                                    {
                                                        ID = pcs.ID,
                                                        Name = pcs.Name,
                                                        Quantity = pcs.Quantity,
                                                        ProductColorID = x.ID,
                                                    }
                                                    ).ToList(),
                                                })
                                                .ToListAsync();
        return result;
    }

    public async Task<List<ProductColorVM>> GetAll()
    {
        var result = await context.ProductColors.Where(x => x.Status == Status.Show).Include(x => x.ProductColorImages).Include(x => x.ProductColorSizes).ToListAsync();

        var data = result.Select(x => new ProductColorVM()
        {
            ID = x.ID,
            Name = x.Name,
            PathImage = x.PathImage,
            ProductID = x.ProductID,
            ProductColorImages = x.ProductColorImages.Where(x => x.Status == Status.Show)
                                                    .Select(pci => new ProductColorImageVM()
                                                    {
                                                        ID = pci.ID,
                                                        Name = pci.Name,
                                                        PathImage = pci.PathImage,
                                                        ProductColorID = pci.ProductColorID,
                                                    }).ToList(),
            ProductColorSizes = x.ProductColorSizes.Where(x => x.Status == Status.Show)
                                                    .Select(pcs => new ProductColorSizeVM()
                                                    {
                                                        ID = pcs.ID,
                                                        Name = pcs.Name,
                                                        Quantity = pcs.Quantity,
                                                        ProductColorID = pcs.ProductColorID,
                                                    }).ToList(),
        }).ToList();

        return data;
    }
    async Task<List<ProductColorImageVM>> GetProductColorImageVM(int productColorID)
    {
        return await context.ProductColorImages.Where(x => x.ProductColorID == productColorID
                                                        && x.Status == Status.Show)
                                                .Select(pci => new ProductColorImageVM()
                                                {
                                                    ID = pci.ID,
                                                    Name = pci.Name,
                                                    PathImage = pci.PathImage,
                                                    ProductColorID = pci.ProductColorID,
                                                }).ToListAsync();
    }
    async Task<List<ProductColorSizeVM>> GetProductColorSizeVM(int productColorID)
    {
        return await context.ProductColorSizes.Where(x => x.ProductColorID == productColorID
                                                        && x.Status == Status.Show)
                                                .Select(pcs => new ProductColorSizeVM()
                                                {
                                                    ID = pcs.ID,
                                                    Name = pcs.Name,
                                                    Quantity = pcs.Quantity,
                                                    ProductColorID = pcs.ProductColorID,
                                                }).ToListAsync();
    }
}