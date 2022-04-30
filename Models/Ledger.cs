using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleLedger.Models
{
   
    public class Ledger
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public TransactionType TransactionType { get; set; }
        public double AccountBalance { get; set; }
    }

    public enum TransactionType
    {
        Credit,
        Debit
    }
}
