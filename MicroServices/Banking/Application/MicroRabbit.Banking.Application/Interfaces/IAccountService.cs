using System.Collections.Generic;
using System.Threading.Tasks;
using MicroRabbit.Banking.Core.Entities;

namespace MicroRabbit.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        Task<IEnumerable<Account>> GetAccounts();
    }
}