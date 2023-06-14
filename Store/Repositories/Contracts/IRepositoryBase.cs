using System.Linq.Expressions;

namespace Store.Repositories.Contracts
{
    public interface IRepositoryBase<T>
    {
        //Sorgulanabilir T formatı
        IQueryable<T> FindAll(bool trackChanges);
        T? FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
    }
}