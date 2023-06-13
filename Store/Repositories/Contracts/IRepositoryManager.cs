namespace Store.Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IProductRepository Product {get;}

        //Kayıtları kaydetmek için;
        void Save();
    }
}