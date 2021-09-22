using MicroRabbit.Domain.Core.Commands;

namespace MicroRabbit.Banking.Core.Commands
{
    public abstract class TransferCommand : Command
    {
        public int Source { get; protected set; }
        public int Destination { get; protected set; }
        public decimal Amount { get; protected set; }
    }
}