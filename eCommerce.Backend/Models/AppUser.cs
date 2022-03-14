namespace eCommerce.Backend.Models;

public class AppUser
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string UserName { get; set; }
    public string PasswordHash { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime Dob { get; set; }
    public int RoleId { get; set; }
    public AppRole AppRole { get; set; }
    public List<Order> Orders { get; set; }
    public List<Rate> Rates { get; set; }
}
