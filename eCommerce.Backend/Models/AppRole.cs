namespace eCommerce.Backend.Models;

public class AppRole
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<AppUser> AppUsers { get; set; }
}
