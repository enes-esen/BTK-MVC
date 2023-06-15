using Entities;
using Microsoft.AspNetCore.Mvc;
using Store.Repositories.Contracts;

namespace StoreApp
{
    public class CategoryController : Controller
    {
        private readonly IRepositoryManager _manager;

        public CategoryController(IRepositoryManager manager)
        {
            _manager = manager;
        }
        public IActionResult Index()
        {
            var model = _manager.Category.FindAll(false);
            return View(model);
        }
    }
    
}