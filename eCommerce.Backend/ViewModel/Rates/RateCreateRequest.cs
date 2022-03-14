namespace eCommerce.Backend.ViewModel.Rates;

public class RateCreateRequest
{
    public int ProductID { get; set; }
    public Product Product { get; set; }
    public int Point { get; set; }
    public string Content { get; set; }
    public int UserID { get; set; }
    public AppUser AppUser { get; set; }
    public RateStatus Status { get; set; }
    public DateTime CreatedAt { get; set; }
}
