using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

//Connect database
builder.Services.AddDbContext<eCommerceContext>(option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString(SystemConstant.MainConnectionString)));

//Declare DI
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IFileStorageService, FileStorageService>();
builder.Services.AddTransient<IProductColorService, ProductColorService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();

// Add services to the container.
builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "eCommerce API",
        Description = "An ASP.NET Core Web API for managing eCommerce items",
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger(options =>
    {
        options.SerializeAsV2 = true;
    });
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

app.UseAuthorization();

app.MapControllers();

app.Run();
