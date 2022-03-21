namespace eCommerce.Backend.Models;

public class Product
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
    public Status Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public List<ProductColor> ProductColors { get; set; }
    public List<Rate> Rates { get; set; }
}
