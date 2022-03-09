namespace eCommerce.Backend.ViewModel.ProductColors;

public class ProductColorCreateRequest
{
    public string Name { get; set; }
    public IFormFile PathImage { get; set; }
    public int ProductID { get; set; }
    public DateTime CreatedAt { get; set; }
}
