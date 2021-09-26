using System;
using System.Threading.Tasks;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Core.Events;
using MicroRabbit.Transfer.Core.Interfaces;

namespace MicroRabbit.Transfer.Core.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository _transferRepository;
        public TransferEventHandler(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;

        }
        public Task Handle(TransferCreatedEvent @event)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"subscribed to {@event}");

            _transferRepository.Add(new Entities.TransferLog
            {
                SourceAccount = @event.SourceAccount,
                DestinationAccount = @event.DestinationAccount,
                TransferAmount = @event.Amount
            });

            //use transfer repo to add to db here
            return Task.CompletedTask;
        }
    }
}