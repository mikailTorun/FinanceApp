using FinanceApp.Domain.Entities.Common;

namespace FinanceApp.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : FinanceAppBaseEntity
    {
        Task<bool> AddAsync(T model);
        Task<Guid> SaveAsync(T model);
        Task<bool> AddRangeAsync(List<T> data);
        bool Remove(T model);
        bool RemoveRange(List<T> data);
        Task<bool> RemoveAsync(Guid id);
        bool Update(T model);
        Task<int> SaveAsync();

    }
}
