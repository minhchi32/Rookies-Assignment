namespace eCommerce.Backend.Configurations;

public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        builder.ToTable("AppUsers");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).UseIdentityColumn();
        builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
        builder.Property(x => x.UserName).IsRequired().HasMaxLength(200);
        builder.Property(x => x.PasswordHash).IsRequired().HasMaxLength(200);
        builder.Property(x => x.Dob).IsRequired();
        builder.HasOne(c => c.AppRole).WithMany(x => x.AppUsers).HasForeignKey(x => x.RoleId);
    }
}
