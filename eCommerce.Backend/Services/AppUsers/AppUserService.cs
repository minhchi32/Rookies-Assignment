namespace eCommerce.Backend.Services.AppUsers;
public class AppUserService : IAppUserService
{
    readonly eCommerceContext context;
    public AppUserService(eCommerceContext context)
    {
        this.context = context;
    }

    public async Task<AppUser> GetByID(int userID)
    {
        var user = await context.AppUsers.FindAsync(userID);
        if (user == null)
            throw new NullReferenceException(MessageConstants.AppUserNotExistID + userID);
        return user;
    }
    IQueryable<AppUser> AppUserFilter(IQueryable<AppUser> query, PagedResultBase request)
    {
        if (!String.IsNullOrEmpty(request.Search))
        {
            query = query.Where(b =>
                b.Name.Contains(request.Search));
        }

        return query;
    }

    public async Task<PagedModelDTO<AppUser>> GetAllWithPaging(PagedResultBase request)
    {
        var query = context.AppUsers.AsQueryable();
        query = AppUserFilter(query, request);
        var paged = await query.AsNoTracking()
                                    .PaginateAsync(request);

        var appUsers = paged.Items.ToList();

        return new PagedModelDTO<AppUser>
        {
            PageIndex = paged.PageIndex,
            // PageCount = paged.PageCount,
            TotalRecord = paged.TotalRecord,
            PageSize = request.PageSize,
            Search = request.Search,
            SortColumn = request.SortColumn,
            SortOrder = request.SortOrder,
            Items = appUsers
        };
    }
}