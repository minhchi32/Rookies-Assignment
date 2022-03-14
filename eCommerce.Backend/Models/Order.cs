namespace eCommerce.Backend.Models;

public class Order
{
    public int ID { get; set; }
    public int? UserID { get; set; }
    public AppUser AppUser { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string Note { get; set; }
    public decimal ShippingPrice { get; set; }
    public decimal TotalPrice { get; set; }
    public OrderStatus Status { get; set; }
    public DateTime CreatedAt { get; set; }

    public List<OrderDetail> OrderDetails { get; set; }
}
