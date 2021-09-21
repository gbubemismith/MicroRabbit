using System.Collections.Generic;
using System.Threading.Tasks;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Core.Entities;
using MicroRabbit.Banking.Core.Interfaces;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepo;
        public AccountService(IAccountRepository accountRepo)
        {
            _accountRepo = accountRepo;

        }
        public async Task<IEnumerable<Account>> GetAccounts()
        {
            return await _accountRepo.GetAccounts();
        }
    }
}