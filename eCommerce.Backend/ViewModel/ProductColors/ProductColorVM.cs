namespace eCommerce.Backend.ViewModel.ProductColors;

public class ProductColorVM
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string PathImage { get; set; }
    public int ProductID { get; set; }
    public List<ProductColorImage> ProductColorImages { get; set; }
    public List<ProductColorSize> ProductColorSizes { get; set; }
}
