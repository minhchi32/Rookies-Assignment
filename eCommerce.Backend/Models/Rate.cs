using RookieShop.Shared.Enums;

namespace eCommerce.Backend.Models;

public class Rate
{
    public int ID { get; set; }
    public int ProductID { get; set; }
    public Product Product { get; set; }
    public int Point { get; set; }
    public string Content { get; set; }
    // public int OrderID { get; set; }
    // public Order Order { get; set; }
    public RateStatus Status { get; set; }
    public DateTime CreatedAt { get; set; }
}
