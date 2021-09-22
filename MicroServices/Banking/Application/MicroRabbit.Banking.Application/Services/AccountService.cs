using System.Collections.Generic;
using System.Threading.Tasks;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Core.Commands;
using MicroRabbit.Banking.Core.Entities;
using MicroRabbit.Banking.Core.Interfaces;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepo;
        private readonly IEventBus _eventBus;
        public AccountService(IAccountRepository accountRepo, IEventBus eventBus)
        {
            _eventBus = eventBus;
            _accountRepo = accountRepo;

        }
        public async Task<IEnumerable<Account>> GetAccounts()
        {
            return await _accountRepo.GetAccounts();
        }

        public async Task TransferFunds(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(accountTransfer.SourceAccount, accountTransfer.DestinationAccount, accountTransfer.TransferAmount);

            await _eventBus.SendCommand(createTransferCommand);
        }
    }
}