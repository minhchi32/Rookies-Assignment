namespace eCommerce.Shared.DTO;

public class PagedResultDTO<T>
{
    public List<T> Items { get; set; }
    public int TotalRecord { get; set; }
}
