using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Transfer.Core.Events
{
    public class TransferCreatedEvent : Event
    {
        public int SourceAccount { get; private set; }
        public int DestinationAccount { get; private set; }
        public decimal Amount { get; private set; }

        public TransferCreatedEvent(int sourceAccount, int destinationAccount, decimal amount)
        {
            SourceAccount = sourceAccount;
            DestinationAccount = destinationAccount;
            Amount = amount;
        }
    }
}