using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SingleLedger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleLedger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LedgerController : ControllerBase
    {
        public LedgerController()
        {
            //passing service interface to use service methods
        }
        public IActionResult GetLeger()
        {
            //call service method to getLedgers
            return null;
        }

        public IActionResult AddLedger(Ledger ledger)
        {
            //call service method to add
            return null;
        }
    }
}
