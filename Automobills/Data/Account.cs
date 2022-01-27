using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Automobills.Data
{
    class Account
    {
        private TransactionList mTransactionList = new TransactionList();

        public Account(DataRow r)
        {
            object o = r["INITIALBAL"];
            System.Type type = o.GetType();
            ID = (long)r["ACCOUNTID"];
            Name = (string)r["ACCOUNTNAME"];
            InitialBalance = (decimal)r["INITIALBAL"];            
        }

        public void LoadTransactions(DatabaseInterface dbif, AccountList accountList)
        {
            mTransactionList.LoadTransactions(dbif, ID, accountList);

            CurrentBalance = InitialBalance;

            foreach (Transaction t in mTransactionList.Transactions)
            {
                if (t.TransCode == "Withdrawal")
                {
                    CurrentBalance -= t.Amount;
                }
                else if (t.TransCode == "Deposit")
                {
                    CurrentBalance += t.Amount;
                }
                else if (t.TransCode == "Transfer")
                {
                    if (this == t.FromAccount)
                    {
                        CurrentBalance -= t.Amount;
                    }
                    else
                    {
                        CurrentBalance += t.Amount;
                    }
                }
            }
        }

        public long ID
        {
            get;set;
        }

        public string Name
        {
            get;set;
        }

        public decimal InitialBalance
        {
            get;set;
        }

        public decimal CurrentBalance
        {
            get;set;
        }
    }
}
