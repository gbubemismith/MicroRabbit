namespace MicroRabbit.Transfer.Core.Entities
{
    public class TransferLog
    {
        public int Id { get; set; }
        public int SourceAccount { get; set; }
        public int DestinationAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}