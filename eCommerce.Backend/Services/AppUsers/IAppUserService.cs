namespace eCommerce.Backend.Services.AppUsers;
public interface IAppUserService
{
    Task<AppUser> GetByID(int id);
    Task<PagedModelDTO<AppUser>> GetAllWithPaging(PagedResultBase request);
}