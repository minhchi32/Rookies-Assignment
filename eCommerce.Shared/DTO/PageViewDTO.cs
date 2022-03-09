namespace eCommerce.Shared.DTO;

public class PageViewDTO<T>
{
    public List<T> Items { get; set; }
    public int TotalRecord { get; set; }
}
