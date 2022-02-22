using RookieShop.Shared.Enums;

namespace eCommerce.Backend.Models;

public class ProductColorSize
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int ProductColorID { get; set; }
    public ProductColor ProductColor { get; set; }
    public int Quantity { get; set; }
    public int QuantitySale { get; set; }
    public Status Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public List<OrderDetail> OrderDetails { get; set; }
}
