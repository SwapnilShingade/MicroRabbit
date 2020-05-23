using MicroRabbit.Banking.Domain.Models;
using MicrpRabbit.Banking.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrpRabbit.Banking.Application.Interfaces
{
   public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransfer accountTransfer);
    }
}
