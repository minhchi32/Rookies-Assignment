namespace eCommerce.Backend.ViewModel.Products;

public class ProductVM
{
    public int ID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal DecreasedPrice { get; set; }
    public int CategoryID { get; set; }
    public Category Category { get; set; }
    public int QuantitySale { get; set; }
    public int TotalPointRate { get; set; }
    public int CountRate { get; set; }
    public List<ProductColorVM> ProductColors { get; set; }
}
