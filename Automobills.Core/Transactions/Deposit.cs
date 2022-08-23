using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobills.Core.Transactions
{
    public class Deposit : Transaction
    {
        public override void Apply()
        {
            Source.DebitAccount(this.Amount);
            Destination.CreditAccount(this.Amount);
        }
    }
}
