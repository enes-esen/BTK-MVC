namespace Store.Repositories.Contracts
{
    public interface IRepositoryBase<T>
    {
        //Sorgulanabilir T formatı
        IQueryable<T> FindAll(bool trackChanges);
    }
}