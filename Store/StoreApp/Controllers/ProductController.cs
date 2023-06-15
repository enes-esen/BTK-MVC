using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;
using Services.Contracts;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IConfiguration _configuration;
        //private readonly IRepositoryManager _manager;
        private readonly IServiceManager _manager;

        public ProductController(IConfiguration configuration, IServiceManager manager)
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
            //var model = _manager.Product.GetAllProducts(false);

            //Service Manager Kullanımı
            var model = _manager.ProductService.GetAllProducts(false);
            
            return View(model);
        }
        public IActionResult Get([FromRoute(Name = "id")] int id)
        {
            //Context Kullanımı
            //Product product = _context.Products.First(p => p.ProductId.Equals(id));

            //Manager kullanımı
            //var model = _manager.Product.GetOneProduct(id, false);

            //Service Manager kullanımı
            var model = _manager.ProductService.GetOneProduct(id, false);
            if(model is null)
            {
                throw new Exception("Product not found!");
            }

            return View(model);
        }
    }    
}