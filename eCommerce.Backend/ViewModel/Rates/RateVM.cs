namespace eCommerce.Backend.ViewModel.Rates;

public class RateVM
{
    public int ProductID { get; set; }
    public Product Product { get; set; }
    public int Point { get; set; }
    public string Content { get; set; }
    public int UserID { get; set; }
    public AppUser AppUser { get; set; }
    public DateTime CreateAt{get;set;}
}
