namespace eCommerce.Backend.ViewModel.Products;

public class ProductUpdateRequest
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public decimal DecreasedPrice { get; set; }
    public int CategoryID { get; set; }
    public string SeoTitle { get; set; }
    public string SeoDescription { get; set; }
    public Status Status { get; set; }
    public DateTime? ModifiedAt { get; set; }
}