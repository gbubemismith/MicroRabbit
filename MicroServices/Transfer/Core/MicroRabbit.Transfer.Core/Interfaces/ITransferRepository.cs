using System.Collections.Generic;
using System.Threading.Tasks;
using MicroRabbit.Transfer.Core.Entities;

namespace MicroRabbit.Transfer.Core.Interfaces
{
    public interface ITransferRepository
    {
        Task<IEnumerable<TransferLog>> GetTransfers();
    }
}