using FinanceApp.Domain.Entities;
using FinanceApp.Domain.Entities.Common;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System;
using Microsoft.EntityFrameworkCore.Design;
using FinanceApp.Domain.Enums;

namespace FinanceApp.Persistence.Contexts
{
    public class FinanceAppDbContext : IdentityDbContext<FinanceAppUser,FinanceAppRole,Guid>
    {
        public FinanceAppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<FinancialInstitution> FinancialInstitutions  { get; set; }
        public DbSet<Notification> Notifications  { get; set; }
        public DbSet<RequestEarlyPayment> RequestEarlyPayments  { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Buyer>()
                        .HasIndex(p => new { p.TaxId })
                        .IsUnique(true);
            builder.Entity<Supplier>()
                        .HasIndex(p => new { p.TaxId })
                        .IsUnique(true);
        }

        //Interceptor
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var data = ChangeTracker.Entries<FinanceAppBaseEntity>();
            foreach(var item in data)
            {
                _ = item.State switch
                {
                    EntityState.Added => item.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => item.Entity.UpdatedDate = DateTime.UtcNow
                };
            }            
            var invoices = ChangeTracker.Entries<Invoice>();
            foreach(var item in invoices)
            {
                _ = item.State switch
                {
                    EntityState.Added => item.Entity.InvoiceStatus = InvoiceStatus.New
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
