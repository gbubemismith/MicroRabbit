using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MicroRabbit.Banking.Core.Commands;
using MicroRabbit.Banking.Core.Events;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Banking.Core.CommandHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _eventBus;
        public TransferCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }
        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            //publish event to Rabbitmq
            _eventBus.Publish(new TransferCreatedEvent(request.Source, request.Destination, request.Amount));

            return Task.FromResult(true);
        }
    }
}