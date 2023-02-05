using AutoMapper;
using FinanceApp.Application.Abstruction.Services.FinanceAppUser;
using FinanceApp.Application.Constants;
using FinanceApp.Application.Features.FinanceAppUser.Commands;
using FinanceApp.Domain.Entities.Common;
using Microsoft.AspNetCore.Identity;
using e = FinanceApp.Domain.Entities.Common;
namespace FinanceApp.Persistence.Services.FinanceAppUser
{
    public class FinanceAppUserService : IFinanceAppUserService
    {
        private readonly UserManager<e.FinanceAppUser> _userManager;
        private readonly RoleManager<e.FinanceAppRole> _roleManager;
        private readonly IMapper _mapper;

        public FinanceAppUserService(RoleManager<FinanceAppRole> roleManager, UserManager<e.FinanceAppUser> userManager = null, IMapper mapper = null)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _mapper = mapper;
        }
        
        public async Task<CreateFinanceAppUserCommandResponse> CreateUserAsync(CreateFinanceAppUserCommandRequest userRequest)
        {
            var user = _mapper.Map<e.FinanceAppUser>(userRequest);
            user.Id = Guid.NewGuid();
            var result = await _userManager.CreateAsync(user, userRequest.Password);

            if (result.Succeeded)
            {
                if (!await _roleManager.RoleExistsAsync(FinanceAppUserRole.Buyer))
                    await _roleManager.CreateAsync(new FinanceAppRole() { Name = FinanceAppUserRole.Buyer });
                if (!await _roleManager.RoleExistsAsync(FinanceAppUserRole.Supplier))
                    await _roleManager.CreateAsync(new FinanceAppRole() { Name = FinanceAppUserRole.Supplier });
                if (!await _roleManager.RoleExistsAsync(FinanceAppUserRole.FinancialInstitution))
                    await _roleManager.CreateAsync(new FinanceAppRole() { Name = FinanceAppUserRole.FinancialInstitution});

                if (await _roleManager.RoleExistsAsync(userRequest.Role))
                {
                    await _userManager.AddToRoleAsync(user, userRequest.Role);
                }
            }
            return new() { IsSucceed = result.Succeeded, Errors = result.Errors };
        }

        public async Task UpdateRefreshToken(string refreshToken, e.FinanceAppUser user, DateTime accessTokenLifeTime, int refreshTokenTime)
        {
            if (user != null)
            {
                user.RefreshToken = refreshToken;
                user.RefreshTokenEndDate = accessTokenLifeTime.AddMinutes(refreshTokenTime);
                await _userManager.UpdateAsync(user);
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }
    }
}
