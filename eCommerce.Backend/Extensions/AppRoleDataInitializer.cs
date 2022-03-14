namespace eCommerce.Backend.Extensions;

public static class AppRoleDataInitializer
{
    public static void SeedAppRoleData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AppRole>().HasData(
            new AppRole()
            {
                Id = 1,
                Name = "admin",
            },
            new AppRole()
            {
                Id = 2,
                Name = "customer",
            }
        );
    }
}