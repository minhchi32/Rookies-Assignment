using eCommerce.Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RookieShop.Shared.Enums;

namespace eCommerce.Backend.Configurations;

public class ProductColorSizeConfiguration : IEntityTypeConfiguration<ProductColorSize>
{
    public void Configure(EntityTypeBuilder<ProductColorSize> builder)
    {
        builder.ToTable("ProductColorSizes");
        builder.HasKey(x => x.ID);
        builder.Property(x => x.ID).UseIdentityColumn();
        builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
        builder.HasOne(c => c.ProductColor).WithMany(x => x.ProductColorSizes).HasForeignKey(x => x.ProductColorID);
        builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);
    }
}
