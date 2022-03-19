using eCommerce.Shared.Enums;

namespace eCommerce.Shared.DTO;

public class PagedResultBase
{
    public int PageIndex { get; set; } = 1;
    public int PageSize { get; set; } = 10;
    public string? Search { get; set; }
    public SortOrder SortOrder { get; set; }
    public string SortColumn { get; set; } = "ID";
    public int TotalRecord { get; set; }
    public int PageCount
    {
        get
        {
            var pageCount = TotalRecord * 1.0 / PageSize;
            return (int)Math.Ceiling(pageCount);
        }
    }
}
