using eCommerce.Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RookieShop.Shared.Enums;

namespace eCommerce.Backend.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");
        builder.HasKey(x => x.ID);
        builder.Property(x => x.ID).UseIdentityColumn();
        builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
        builder.Property(x => x.Status).HasDefaultValue(Status.Show);
        builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);
        builder.HasOne(c => c.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryID);
    }
}
