using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace FinanceApp.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection collection)
        {
            collection.AddMediatR(typeof(ServiceRegistration));
            collection.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
