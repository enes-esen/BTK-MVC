using Microsoft.EntityFrameworkCore;
using Repositories;
using Store.Repositories;
using Store.Repositories.Contracts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RepositoryContext>(options => 
{
    options
    .UseNpgsql(builder
                .Configuration
                .GetConnectionString("sqlConnection")
                ,b => b.MigrationsAssembly("StoreApp"));
});

builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name:"default", 
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();