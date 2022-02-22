using eCommerce.Backend.Configurations;
using eCommerce.Backend.Models;
using Microsoft.EntityFrameworkCore;
namespace eCommerce.Backend.Data;
public class eCommerceContext : DbContext
{
    public eCommerceContext(DbContextOptions<eCommerceContext> options) : base(options)
    {
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductColor> ProductColors { get; set; }
    public DbSet<ProductColorImage> ProductColorImages { get; set; }
    public DbSet<ProductColorSize> ProductColorSizes { get; set; }
    public DbSet<Rate> Rates { get; set; }
    public DbSet<Slide> Slides { get; set; }
}
