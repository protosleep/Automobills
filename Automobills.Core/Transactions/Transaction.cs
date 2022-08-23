using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automobills.Core.Accounts;

namespace Automobills.Core.Transactions
{
    public abstract class Transaction
    {
        public Account Source { get; set; }
        public Account Destination { get; set; }

        public double Amount { get; set; }

        public abstract void Apply();
    }
}
