namespace eCommerce.Backend.Configurations;

public class RateConfiguration : IEntityTypeConfiguration<Rate>
{
    public void Configure(EntityTypeBuilder<Rate> builder)
    {
        builder.ToTable("Rates");
        builder.HasKey(x => x.ID);
        builder.Property(x => x.ID).UseIdentityColumn();
        builder.Property(x => x.Point).IsRequired().HasMaxLength(200);
        builder.Property(x => x.Status).HasDefaultValue(RateStatus.Pending);
        builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);
        builder.HasOne(c => c.Product).WithMany(x => x.Rates).HasForeignKey(x => x.ProductID);
    }
}
