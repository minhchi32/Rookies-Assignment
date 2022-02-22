using eCommerce.Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RookieShop.Shared.Enums;

namespace eCommerce.Backend.Configurations;

public class ProductColorConfiguration : IEntityTypeConfiguration<ProductColor>
{
    public void Configure(EntityTypeBuilder<ProductColor> builder)
    {
        builder.ToTable("ProductColors");
        builder.HasKey(x => x.ID);
        builder.Property(x => x.ID).UseIdentityColumn();
        builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
        builder.HasOne(c => c.Product).WithMany(x => x.ProductColors).HasForeignKey(x => x.ProductID);
        builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);
    }
}
