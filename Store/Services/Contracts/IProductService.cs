using Entities.Models;

namespace Services.Contracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts(bool trackChanges);
        Product? GetOneProduct(int id, bool trackChangles);
        void CreateProduct(Product product);
        void UpdateOneProdut(Product product);
    }
}