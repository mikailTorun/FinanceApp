namespace FinanceApp.Domain.Entities.Common
{
    public class FinanceAppBaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
