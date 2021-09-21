using System.Collections.Generic;
using System.Threading.Tasks;
using MicroRabbit.Banking.Core.Entities;
using MicroRabbit.Banking.Core.Interfaces;
using MicroRabbit.Banking.Infrastructure.Data;

namespace MicroRabbit.Banking.Infrastructure.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDbContext _context;
        public AccountRepository(BankingDbContext context)
        {
            _context = context;

        }
        public async Task<IEnumerable<Account>> GetAccounts()
        {
            return _context.Accounts;
        }
    }
}