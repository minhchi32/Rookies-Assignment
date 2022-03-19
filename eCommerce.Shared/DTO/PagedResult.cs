namespace eCommerce.Shared.DTO;

public class PagedModelDTO<T> : PagedResultBase
{
    public List<T> Items { get; set; }
}
