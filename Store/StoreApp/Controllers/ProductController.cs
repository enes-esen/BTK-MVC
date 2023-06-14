using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Store.Repositories.Contracts;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepositoryManager _manager;
        private readonly IConfiguration _configuration;

        public ProductController(IConfiguration configuration, IRepositoryManager manager)
        {
            _manager = manager;
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

            //Context Kullanımı
            //var model = _context.Products.ToList();
            
            //Manager kullanımı
            var model = _manager.Product.GetAllProducts(false);
            
            return View(model);
        }
        public IActionResult Get(int id)
        {
            //Context Kullanımı
            //Product product = _context.Products.First(p => p.ProductId.Equals(id));

            var model = _manager.Product.GetOneProduct(id, false);

            return View(model);
        }
    }
    
}