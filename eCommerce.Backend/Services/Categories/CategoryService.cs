namespace eCommerce.Backend.Services.Categories;
public class CategoryService : ICategoryService
{
    readonly eCommerceContext context;
    public CategoryService(eCommerceContext context)
    {
        this.context = context;
    }

    public async Task<int> Create(CategoryCreateRequest request)
    {
        var category = new Category()
        {
            Name = request.Name,
            ParentId = request.ParentId,
            CreatedAt = DateTime.Now,
        };
        context.Categories.Add(category);
        await context.SaveChangesAsync();
        return category.ID;
    }

    public async Task<int> Delete(int categoryID)
    {
        var category = await context.Categories.FindAsync(categoryID);
        if (category == null)
            throw new NullReferenceException(MessageConstants.CategoryNotExistID + categoryID);
        category.DeletedAt = DateTime.Now;
        category.Status = Status.Deleted;
        context.Categories.Update(category);
        return await context.SaveChangesAsync();
    }

    public async Task<CategoryVM> GetByID(int categoryID)
    {
        var category = await context.Categories.FindAsync(categoryID);
        if (category == null)
            throw new NullReferenceException(MessageConstants.CategoryNotExistID + categoryID);
        return new CategoryVM()
        {
            ID = category.ID,
            Name = category.Name,
            ParentId = category.ParentId,
        };
    }

    public async Task<int> Update(CategoryUpdateRequest request)
    {
        var category = await context.Categories.FindAsync(request.ID);
        if (category == null)
            throw new NullReferenceException(MessageConstants.CategoryNotExistID + request.ID);

        category.Name = request.Name;
        category.ParentId = request.ParentId;
        category.Status = request.Status;
        category.ModifiedAt = DateTime.Now;
        context.Categories.Update(category);

        return await context.SaveChangesAsync();
    }

    public async Task<PagedModelDTO<ProductVM>> GetListProductCategoryID(GetProductPagingRequest request)
    {
        var result = await context.Products.Where(x => x.CategoryID == request.CategoryID && x.Status == Status.Show)
                                            .Include(x => x.ProductColors)
                                            .ThenInclude(x => x.ProductColorImages)
                                            .Include(x => x.ProductColors)
                                            .ThenInclude(x => x.ProductColorSizes)
                                            .ToListAsync();

        int totalRow = result.Count();
        var data = result.Skip((request.PageIndex - 1) * request.PageSize)
                        .Take(request.PageSize)
                        .Select(x => new ProductVM()
                        {
                            ID = x.ID,
                            Name = x.Name,
                            Price = x.Price,
                            DecreasedPrice = x.DecreasedPrice,
                            CategoryID = x.CategoryID,
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

        var pagedResult = new PagedModelDTO<ProductVM>()
        {
            TotalRecord = totalRow,
            PageIndex = request.PageIndex,
            PageSize = request.PageSize,
            Items = data
        };
        return pagedResult;
    }

    public async Task<List<CategoryVM>> GetAll()
    {
        var result = await context.Categories.Where(x => x.Status == Status.Show)
                                            .ToListAsync();

        var data = result.Select(x => new CategoryVM()
        {
            ID = x.ID,
            Name = x.Name,
            ParentId = x.ParentId,
        }).ToList();

        return data;
    }

    public async Task<PagedModelDTO<CategoryVM>> GetAllWithPaging(PagedResultBase request)
    {
        var query = context.Categories.Where(x => x.Status == Status.Show)
                                            .AsQueryable();
        query = CategoryFilter(query, request);
        var paged = await query.AsNoTracking()
                                    .PaginateAsync(request);

        var categoriesVM = paged.Items.Select(x => new CategoryVM()
        {
            ID = x.ID,
            Name = x.Name,
            ParentId = x.ParentId,
        }).ToList();

        return new PagedModelDTO<CategoryVM>
        {
            PageIndex = paged.PageIndex,
            // PageCount = paged.PageCount,
            TotalRecord = paged.TotalRecord,
            PageSize = request.PageSize,
            Search = request.Search,
            SortColumn = request.SortColumn,
            SortOrder = request.SortOrder,
            Items = categoriesVM
        };
    }

    IQueryable<Category> CategoryFilter(IQueryable<Category> query, PagedResultBase request)
    {
        if (!String.IsNullOrEmpty(request.Search))
        {
            query = query.Where(b =>
                b.Name.Contains(request.Search));
        }

        return query;
    }
}