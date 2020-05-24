using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Domain.Interfaces
{
	public interface ITransferRepository
	{
        IEnumerable<TransferLog> GetTransferLogs();
	}
}
