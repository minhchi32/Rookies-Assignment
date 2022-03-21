namespace eCommerce.Backend.ViewModel.Products;

public class ProductCreateRequest
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal DecreasedPrice { get; set; }
    public int CategoryID { get; set; }
    public DateTime CreatedAt { get; set; }
}
