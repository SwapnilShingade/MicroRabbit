using MicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Domain.Interfaces
{
	public interface IAccountRepository
	{
        IEnumerable<Account> GetAccounts();
	}
}
