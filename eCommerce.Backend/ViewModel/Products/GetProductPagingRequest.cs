namespace eCommerce.Backend.ViewModel.Products;

public class GetProductPagingRequest : PagingRequestBase
{
    public string Keyword { get; set; }
    public int? CategoryID { get; set; }
}
