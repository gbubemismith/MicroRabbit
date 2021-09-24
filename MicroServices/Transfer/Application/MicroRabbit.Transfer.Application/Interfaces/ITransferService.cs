using System.Collections.Generic;
using System.Threading.Tasks;
using MicroRabbit.Transfer.Core.Entities;

namespace MicroRabbit.Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        Task<IEnumerable<TransferLog>> GetTransfers();
    }
}