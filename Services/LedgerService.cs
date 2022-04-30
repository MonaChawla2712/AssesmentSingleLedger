using SingleLedger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleLedger.Services
{
    public class LedgerService // implemented though service interface
    {
        public List<Ledger> GetLedgers()
        {
            return new List<Ledger>();
        }

        public Ledger AddLedger()
        {
            return new Ledger();
        }
    }
}
