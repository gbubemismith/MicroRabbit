using System.Collections.Generic;
using System.Threading.Tasks;
using MicroRabbit.Banking.Core.Entities;

namespace MicroRabbit.Banking.Core.Interfaces
{
    public interface IAccountRepository
    {
        Task<IEnumerable<Account>> GetAccounts();
    }
}