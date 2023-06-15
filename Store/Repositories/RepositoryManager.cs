using Repositories;
using Repositories.Contracts;
using Store.Repositories.Contracts;

namespace Store.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;

        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryManager;

        public RepositoryManager(RepositoryContext context, IProductRepository productRepository, ICategoryRepository categoryManager = null)
        {
            _context = context;
            _productRepository = productRepository;
            _categoryManager = categoryManager;
        }

        public IProductRepository Product => _productRepository;

        public ICategoryRepository Category => _categoryManager;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}