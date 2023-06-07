using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RepositoryContext>(options => 
{
    options
    .UseNpgsql(builder
                .Configuration
                .GetConnectionString("sqlConnection"));
});

var app = builder.Build();

app.UseRouting();
app.UseHttpsRedirection();

app.MapControllerRoute(
    name:"default", 
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
