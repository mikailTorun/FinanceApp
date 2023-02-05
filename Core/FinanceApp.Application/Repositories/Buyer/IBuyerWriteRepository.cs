using entity = FinanceApp.Domain.Entities;

namespace FinanceApp.Application.Repositories.Buyer
{
    public interface IBuyerWriteRepository : IWriteRepository<entity.Buyer>
    {
    }
}
