namespace eCommerce.Backend.Models;

public class OrderDetail
{
    public int ID { get; set; }
    public int OrderID { get; set; }
    public Order Order { get; set; }
    public int ProductColorSizeID { get; set; }
    public ProductColorSize ProductColorSize { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}
