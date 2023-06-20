using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace StoreApp.Components
{
    public class ProductSummaryViewComponent : ViewComponent
    {
        // private readonly RepositoryContext _context;

        // public ProductSummary(RepositoryContext context)
        // {
        //     _context = context;
        // }

        private readonly IServiceManager _manager;

        public ProductSummaryViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public string Invoke()
        {
            //context
            //return _context.Products.Count().ToString();

            //ServiceManager
            return _manager.ProductService.GetAllProducts(false).Count().ToString();
        }
    }
}