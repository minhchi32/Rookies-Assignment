using RookieShop.Shared.Enums;

namespace eCommerce.Backend.Models;

public class Category
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int? ParentId { get; set; }
    public Status Status { get; set; }
    public string SeoTitle { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public DateTime? DeletedAt { get; set; }

    public List<Product> Products { get; set; }
}
