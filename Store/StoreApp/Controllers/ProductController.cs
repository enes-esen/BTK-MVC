using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly RepositoryContext _context;
        private readonly IConfiguration _configuration;

        public ProductController(IConfiguration configuration, RepositoryContext context)
        {
            _context = context;
            _configuration = configuration;
        }
        

        public IActionResult Index()
        {
            /*
            var context = new RepositoryContext(
                new DbContextOptionsBuilder<RepositoryContext>()
                .UseNpgsql(_configuration.GetConnectionString("sqlConnection"))
                .Options
            );
            return context.Products;
            */
            //return _context.Products;
            var model = _context.Products.ToList();
            return View(model);
        }
        public IActionResult Get(int id)
        {
            Product product = _context.Products.First(p => p.ProductId.Equals(id));
            return View(product);
        }
    }
    
}