using eCommerce.Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RookieShop.Shared.Enums;

namespace eCommerce.Backend.Configurations;

public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
{
    public void Configure(EntityTypeBuilder<OrderDetail> builder)
    {
        builder.ToTable("OrderDetails");
        builder.HasKey(x => x.ID);
        builder.Property(x => x.ID).UseIdentityColumn();
        builder.HasOne(c => c.ProductColorSize).WithMany(x => x.OrderDetails).HasForeignKey(x => x.ProductColorSizeID);
    }
}
