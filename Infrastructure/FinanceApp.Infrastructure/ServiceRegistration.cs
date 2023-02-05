using FinanceApp.Application.Abstruction.Token;
using FinanceApp.Infrastructure.Services.Token;
using Microsoft.Extensions.DependencyInjection;

namespace FinanceApp.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ITokenHandler, TokenHandler>();
        }
    }
}
