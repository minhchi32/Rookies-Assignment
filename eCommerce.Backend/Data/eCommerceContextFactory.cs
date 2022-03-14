namespace eCommerce.Backend.Data;
public class eCommerceContextFactory : IDesignTimeDbContextFactory<eCommerceContext>
{
    public eCommerceContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

        var connectionString = configuration.GetConnectionString("eCommerceDb");

        var optionsBuilder = new DbContextOptionsBuilder<eCommerceContext>();
        optionsBuilder.UseSqlServer(connectionString);

        return new eCommerceContext(optionsBuilder.Options);
    }
}
