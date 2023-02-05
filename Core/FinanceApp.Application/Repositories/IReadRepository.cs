using FinanceApp.Domain.Entities.Common;
using System.Linq.Expressions;

namespace FinanceApp.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : FinanceAppBaseEntity
    {
        IQueryable<T> GetAll(bool tracking = true);
        IQueryable<T> Get(Guid id, bool tracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true);
        Task<T> GetByIdAsync(Guid id, bool tracking = true);
    }
}
