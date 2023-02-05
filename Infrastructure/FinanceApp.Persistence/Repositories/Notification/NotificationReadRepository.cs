using FinanceApp.Application.Repositories.Notification;
using FinanceApp.Persistence.Contexts;
using e = FinanceApp.Domain.Entities;
namespace FinanceApp.Persistence.Repositories.Notification
{
    public class NotificationReadRepository : ReadRepository<e.Notification>, INotificationReadRepository
    {
        public NotificationReadRepository(FinanceAppDbContext financeAppDbContext) : base(financeAppDbContext)
        {
        }
    }
}
