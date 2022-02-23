using eCommerce.Backend.Configurations;
using eCommerce.Backend.Extensions;
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
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Configure using Fluent API
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
        modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new ProductColorConfiguration());
        modelBuilder.ApplyConfiguration(new ProductColorSizeConfiguration());
        modelBuilder.ApplyConfiguration(new ProductColorImageConfiguration());
        modelBuilder.ApplyConfiguration(new RateConfiguration());
        modelBuilder.ApplyConfiguration(new SlideConfiguration());

        //Data seeding
        modelBuilder.Seed();

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.EnableSensitiveDataLogging();
}
}
