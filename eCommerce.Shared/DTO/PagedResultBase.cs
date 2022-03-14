namespace eCommerce.Shared.DTO;

public class PagedResultBase
{
    public int PageIndex { get; set; }
    public int PageSize { get; set; }
    public int TotalRecord { get; set; }
    public int PageCount{
        get{
            var pageCount = TotalRecord*1.0/PageSize;
            return (int)Math.Ceiling(pageCount);
        }
    }
}
