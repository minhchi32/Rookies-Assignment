namespace eCommerce.Backend.ViewModel.Products;

public class GetProductPagingRequest : PagedResultBase
{
    // public string Keyword { get; set; }
    public int? CategoryID { get; set; }
}
