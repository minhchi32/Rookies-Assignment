namespace eCommerce.Backend.ViewModel.ProductColors;

public class ProductColorVM
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string PathImage { get; set; }
    public int ProductID { get; set; }
    public List<ProductColorImageVM> ProductColorImages { get; set; }
    public List<ProductColorSizeVM> ProductColorSizes { get; set; }
}
