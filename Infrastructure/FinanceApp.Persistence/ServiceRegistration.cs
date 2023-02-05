using FinanceApp.Application.Abstruction.Services.Buyer;
using FinanceApp.Application.Abstruction.Services.FinanceAppUser;
using FinanceApp.Application.Abstruction.Services.FinancialInstitutionService;
using FinanceApp.Application.Abstruction.Services.Invoice;
using FinanceApp.Application.Abstruction.Services.Supplier;
using FinanceApp.Application.Repositories.Buyer;
using FinanceApp.Application.Repositories.FinancialInstitution;
using FinanceApp.Application.Repositories.Invoice;
using FinanceApp.Application.Repositories.Supplier;
using FinanceApp.Domain.Entities.Common;
using FinanceApp.Persistence.Contexts;
using FinanceApp.Persistence.Repositories;
using FinanceApp.Persistence.Repositories.FinancialInstitution;
using FinanceApp.Persistence.Repositories.Invoice;
using FinanceApp.Persistence.Repositories.Supplier;
using FinanceApp.Persistence.Services.Buyer;
using FinanceApp.Persistence.Services.FinanceAppUser;
using FinanceApp.Persistence.Services.FinancialInstitutionService;
using FinanceApp.Persistence.Services.Invoice;
using FinanceApp.Persistence.Services.Supplier;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FinanceApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<FinanceAppDbContext>(options => options.UseNpgsql(Configuration.GetConnectionString));
            services.AddScoped<IBuyerService, BuyerService>();
            services.AddIdentity<FinanceAppUser,FinanceAppRole>().AddEntityFrameworkStores<FinanceAppDbContext>();
            services.AddScoped<IBuyerReadRepository, BuyerReadRepository>();
            services.AddScoped<IBuyerWriteRepository, BuyerWriteRepository>();
            services.AddScoped<IFinanceAppUserService, FinanceAppUserService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<ISupplierService, SupplierService>();
            services.AddScoped<ISupplierWriteRepository, SupplierWriteRepository>();
            services.AddScoped<IInvoiceService, InvoiceService>();
            services.AddScoped<IInvoiceWriteRepository, InvoiceWriteRepository>();
            services.AddScoped<IInvoiceReadRepository, InvoiceReadRepository>();
            services.AddScoped<IFinancialInstitutionService, FinancialInstitutionService>();
            services.AddScoped<IFinancialInstitutionWriteRepository, FinancialInstitutionWriteRepository>();
        }
    }
}
