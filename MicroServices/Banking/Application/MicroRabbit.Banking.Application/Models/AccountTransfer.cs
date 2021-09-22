namespace MicroRabbit.Banking.Application.Models
{
    public class AccountTransfer
    {
        public int SourceAccount { get; set; }
        public int DestinationAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}