using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Banking.Data.Context
{
    public class BankingDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public BankingDbContext(DbContextOptions options) : base(options)
        {
          
        }

    }
}
