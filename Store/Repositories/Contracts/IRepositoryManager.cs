using Repositories.Contracts;

namespace Store.Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IProductRepository Product { get; }
        ICategoryRepository Category { get; }

        //Kayıtları kaydetmek için;
        void Save();
    }
}