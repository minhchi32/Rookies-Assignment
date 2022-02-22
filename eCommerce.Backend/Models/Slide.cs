using RookieShop.Shared.Enums;

namespace eCommerce.Backend.Models;

public class Slide
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string PathImage { get; set; }
    public DateTime CreatedAt { get; set; }
    public string LinkProduct { get; set; }
    public Status Status { get; set; }
}
