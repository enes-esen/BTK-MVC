using System.Linq.Expressions;
using Entities;
using Entities.Models;
using Store.Repositories.Contracts;

namespace Repositories.Contracts
{
    public interface ICategoryRepository : IRepositoryBase<Category>
    {
    }
}