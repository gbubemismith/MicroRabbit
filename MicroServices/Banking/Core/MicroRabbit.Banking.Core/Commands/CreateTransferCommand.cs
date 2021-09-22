using MicroRabbit.Domain.Core.Commands;

namespace MicroRabbit.Banking.Core.Commands
{
    public class CreateTransferCommand : TransferCommand
    {
        public CreateTransferCommand(int source, int destination, decimal amount)
        {
            Source = source;
            Destination = destination;
            Amount = amount;
        }
    }
}