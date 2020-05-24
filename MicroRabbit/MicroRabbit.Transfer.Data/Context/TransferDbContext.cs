using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public DbSet<TransferLog> TransferLogs { get; set; }
        public TransferDbContext(DbContextOptions options) : base(options)
        {
          
        }

    }
}
