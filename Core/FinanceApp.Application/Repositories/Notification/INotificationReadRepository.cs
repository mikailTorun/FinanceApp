using entity = FinanceApp.Domain.Entities;

namespace FinanceApp.Application.Repositories.Notification
{
    public interface INotificationReadRepository : IReadRepository<entity.Notification>
    {
    }
}
