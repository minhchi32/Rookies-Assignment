namespace eCommerce.Backend.Extensions;

public static class RateDataInitializer
{
    public static void SeedRateData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Rate>().HasData(
            new Rate()
            {
                ID = 1,
                ProductID = 1,
                Point = 5,
                Status = RateStatus.Approved,
                UserID = 1,
                Content = "Good"
            },
            new Rate()
            {
                ID = 2,
                ProductID = 1,
                Point = 1,
                Status = RateStatus.Approved,
                UserID = 1,
                Content = "Bad"
            },
            new Rate()
            {
                ID = 3,
                ProductID = 1,
                Point = 3,
                Status = RateStatus.Pending,
                UserID = 2,
                Content = "Good"
            },
            new Rate()
            {
                ID = 4,
                ProductID = 1,
                Point = 4,
                Status = RateStatus.Deleted,
                UserID = 2,
                Content = "Good"
            }
        );
    }
}