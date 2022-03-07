namespace eCommerce.Backend.Configurations;

public class SlideConfiguration : IEntityTypeConfiguration<Slide>
{
    public void Configure(EntityTypeBuilder<Slide> builder)
    {
        builder.ToTable("Slides");
        builder.HasKey(x => x.ID);
        builder.Property(x => x.ID).UseIdentityColumn();
        builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
        builder.Property(x => x.PathImage).IsRequired();
        builder.Property(x => x.Status).HasDefaultValue(Status.Show);
        builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);
    }
}
