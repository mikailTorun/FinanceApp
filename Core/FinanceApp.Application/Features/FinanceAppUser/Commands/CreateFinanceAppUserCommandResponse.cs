using FinanceApp.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceApp.Application.Features.FinanceAppUser.Commands
{
    public class CreateFinanceAppUserCommandResponse
    {
        public bool IsSucceed { get; set; }
        public IEnumerable<IdentityError> Errors { get; set; }

    }
}
