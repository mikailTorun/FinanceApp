using entity = FinanceApp.Domain.Entities;

namespace FinanceApp.Application.Repositories.Notification
{
    public interface INotificationWriteRepository : IWriteRepository<entity.Notification>
    {
    }
}
