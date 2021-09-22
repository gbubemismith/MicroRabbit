using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Banking.Core.Events
{
    public class TransferCreatedEvent : Event
    {
        public int SourceAccount { get; private set; }
        public int DestinationAccount { get; private set; }
        public decimal Ammount { get; private set; }

        public TransferCreatedEvent(int sourceAccount, int destinationAccount, decimal amount)
        {
            SourceAccount = sourceAccount;
            DestinationAccount = destinationAccount;
            Ammount = amount;
        }
    }
}