using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using MicrpRabbit.Banking.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrpRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accountRepository;
        public AccountService(IAccountRepository repository)
        {
            accountRepository = repository;

        }
        public IEnumerable<Account> GetAccounts()
        {
            return accountRepository.GetAccounts();
        }
    }
}
