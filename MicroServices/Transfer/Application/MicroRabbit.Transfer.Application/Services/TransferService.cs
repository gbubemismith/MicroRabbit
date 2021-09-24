using System.Collections.Generic;
using System.Threading.Tasks;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Core.Entities;
using MicroRabbit.Transfer.Core.Interfaces;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly IEventBus _eventBus;
        private readonly ITransferRepository _transferRepository;
        public TransferService(ITransferRepository transferRepository, IEventBus eventBus)
        {
            _transferRepository = transferRepository;
            _eventBus = eventBus;
        }
        public async Task<IEnumerable<TransferLog>> GetTransfers()
        {
            return await _transferRepository.GetTransfers();
        }
    }
}