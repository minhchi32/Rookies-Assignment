namespace eCommerce.Backend.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");
        builder.HasKey(x => x.ID);
        builder.Property(x => x.ID).UseIdentityColumn();
        builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
        builder.Property(x=>x.SeoDescription).IsRequired(false);
        builder.Property(x => x.Status).HasDefaultValue(Status.Show);
        builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);
    }
}
