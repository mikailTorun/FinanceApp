using FinanceApp.Application.Repositories.Notification;
using FinanceApp.Persistence.Contexts;
using e = FinanceApp.Domain.Entities;
namespace FinanceApp.Persistence.Repositories.Notification
{
    public class NotificationWriteRepository : WriteRepository<e.Notification>, INotificationWriteRepository
    {
        public NotificationWriteRepository(FinanceAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
