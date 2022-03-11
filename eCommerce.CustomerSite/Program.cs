using eCommerce.CustomerSite.Service.Products;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
IWebHostEnvironment environment = builder.Environment;
builder.Services.AddHttpClient();
// Add services to the container.
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IProductService, ProductService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");
// app.MapRazorPages();

app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                    endpoints.MapRazorPages();
            });
app.Run();
