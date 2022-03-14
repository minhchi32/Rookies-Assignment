namespace eCommerce.Backend.Extensions;

public static class AppUserDataInitializer
{
    public static void SeedAppUserData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AppUser>().HasData(
            new AppUser()
            {
                Id = 1,
                Name = "admin",
                UserName = "admin",
                PasswordHash = "admin",
                Email = "admin@admin.com",
                Dob = new DateTime(1999, 12, 31),
                RoleId = 1,
                PhoneNumber = "0123456789",
            },
            new AppUser()
            {
                Id = 2,
                Name = "customer",
                UserName = "customer",
                PasswordHash = "customer",
                Email = "customer@customer.com",
                Dob = new DateTime(2000, 12, 31),
                RoleId = 2,
                PhoneNumber = "0123456789",
            }
        );
    }
}