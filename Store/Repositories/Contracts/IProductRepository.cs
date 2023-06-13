using Entities.Models;
using Store.Repositories.Contracts;

namespace Store.Repositories
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IQueryable<Product> GetAllProducts(bool trackChanges);
    }

}