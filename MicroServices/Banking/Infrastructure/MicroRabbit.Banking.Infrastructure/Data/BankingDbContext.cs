using MicroRabbit.Banking.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Banking.Infrastructure.Data
{
    public class BankingDbContext : DbContext
    {
        public BankingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
    }
}