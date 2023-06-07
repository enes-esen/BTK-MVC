using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RepositoryContext>(options => 
{
    options
    .UseNpgsql(builder
                .Configuration
                .GetConnectionString("sqlConnection"));
});

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name:"default", 
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();