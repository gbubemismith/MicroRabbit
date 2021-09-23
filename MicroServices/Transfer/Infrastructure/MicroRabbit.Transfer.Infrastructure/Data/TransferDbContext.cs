using MicroRabbit.Transfer.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Transfer.Infrastructure.Data
{
    public class TransferDbContext : DbContext
    {
        public TransferDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TransferLog> TransferLog { get; set; }
    }
}