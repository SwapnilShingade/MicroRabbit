using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Domain.Core.Bus;
using MicrpRabbit.Banking.Application.Interfaces;
using MicrpRabbit.Banking.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrpRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accountRepository;
        private readonly IEventBus eventBus;
        public AccountService(IAccountRepository repository, IEventBus bus)
        {
            accountRepository = repository;
            eventBus = bus;

        }
        public IEnumerable<Account> GetAccounts()
        {
            return accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreatTransferCommand(accountTransfer.fromAccount, accountTransfer.toAccount, accountTransfer.transferAmount);
            eventBus.SendCommand(createTransferCommand);

          
        }
    }
}
