using System;
using System.Collections.Generic;
using System.Text;

namespace MicrpRabbit.Banking.Application.Models
{
   public class AccountTransfer
    {
        public int fromAccount { get; set; }
        public int toAccount { get; set; }
        public decimal transferAmount { get; set; }
    }

}
