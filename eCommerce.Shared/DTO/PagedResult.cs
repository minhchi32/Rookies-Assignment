namespace eCommerce.Shared.DTO;

public class PagedResult<T> : PagedResultBase
{
    public List<T> Items { get; set; }
}
