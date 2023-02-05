using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Application.Features.FinancialInstitution.Commands
{
    public class CreateFinancialInstitutionCommandRequest : IRequest<CreateFinancialInstitutionCommandResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string TaxId { get; set; }
    }
}
