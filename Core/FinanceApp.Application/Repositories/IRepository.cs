using FinanceApp.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Application.Repositories
{
    public interface IRepository<T> where T : FinanceAppBaseEntity
    {
        DbSet<T> Table { get; }
    }
}
