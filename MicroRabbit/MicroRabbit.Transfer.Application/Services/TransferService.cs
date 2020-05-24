using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;

using MicroRabbit.Transfer.Domain.Models;
using MicrpRabbit.Transfer.Application.Interfaces;

using System;
using System.Collections.Generic;
using System.Text;

namespace MicrpRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository transferRepository;
        private readonly IEventBus eventBus;
        public TransferService(ITransferRepository repository, IEventBus bus)
        {
            transferRepository = repository;
            eventBus = bus;

        }
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return transferRepository.GetTransferLogs();
        }
      
        //public void Transfer(AccountTransfer accountTransfer)
        //{
        //    var createTransferCommand = new CreatTransferCommand(
        //        accountTransfer.fromAccount, accountTransfer.toAccount, accountTransfer.transferAmount);
        //    eventBus.SendCommand(createTransferCommand);

          
        //}
    }
}
