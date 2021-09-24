using System.Threading.Tasks;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Core.Events;

namespace MicroRabbit.Transfer.Core.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        public TransferEventHandler()
        {

        }
        public Task Handle(TransferCreatedEvent @event)
        {
            throw new System.NotImplementedException();
        }
    }
}