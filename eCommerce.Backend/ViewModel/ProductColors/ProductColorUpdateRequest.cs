namespace eCommerce.Backend.ViewModel.ProductColors;

public class ProductColorUpdateRequest
{
    public int ID { get; set; }
    public string Name { get; set; }
    public IFormFile PathImage { get; set; }
    public int ProductID { get; set; }
    public Status Status { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}
