namespace eCommerce.Backend.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("Orders");
        builder.HasKey(x => x.ID);
        builder.Property(x => x.ID).UseIdentityColumn();
        builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
        builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(15).IsUnicode(false);
        builder.Property(x => x.Address).IsRequired().HasMaxLength(200);
        builder.Property(x => x.Email).IsRequired().HasMaxLength(200).IsUnicode(false);
        builder.Property(x => x.ShippingPrice).HasDefaultValue(0);
        builder.Property(x => x.TotalPrice).HasDefaultValue(0);
        builder.Property(x => x.Status).HasDefaultValue(OrderStatus.InProgress);
        builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);
        builder.HasOne(c => c.AppUser).WithMany(x => x.Orders).HasForeignKey(x => x.UserID);
    }
}
