using RookieShop.Shared.Enums;

namespace eCommerce.Backend.Models;

public class ProductColor
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string PathImage { get; set; }
    public int ProductID { get; set; }
    public Product Product { get; set; }
    public Status Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public List<ProductColorImage> ProductColorImages { get; set; }
    public List<ProductColorSize> ProductColorSizes { get; set; }
}
