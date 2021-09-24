using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Transfer.Core.Entities;
using MicroRabbit.Transfer.Core.Interfaces;
using MicroRabbit.Transfer.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Transfer.Infrastructure.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _context;
        public TransferRepository(TransferDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TransferLog>> GetTransfers()
        {
            return await _context.TransferLog.ToListAsync();
        }
    }
}