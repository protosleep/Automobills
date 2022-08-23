using Automobills.Core.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobills.Core.Accounts
{
    public class Account
    {
        public double InitialBalance { get; set; } = 0.0;
        public double Balance { get; private set; } = 0.0;

        public void ApplyTransaction(Transaction t)
        {
            Transactions.Add(t);
        }

        public void DebitAccount(double amount)
        {
            Balance -= amount;
        }

        public void CreditAccount(double amount)
        {
            Balance += amount;
        }

        public List<Transaction> Transactions { get; } = new();
    }
}
