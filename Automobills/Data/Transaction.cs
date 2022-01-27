using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Automobills.Data
{
    class Transaction
    {
        public Transaction(DataRow r, AccountList accountList)
        {
            ID = (long)r["TRANSID"];
            long fromAccountId = (long)r["ACCOUNTID"];
            long toAccountId = (long)r["TOACCOUNTID"];

            foreach (Account a in accountList.Accounts)
            {
                if (a.ID == fromAccountId)
                {
                    FromAccount = a;
                }

                if (a.ID == toAccountId)
                {
                    ToAccount = a;
                }
            }

            Amount = (decimal)r["TRANSAMOUNT"];
            TransCode = (string)r["TRANSCODE"];
        }

        public long ID
        {
            get;set;
        }

        public Account FromAccount
        {
            get;set;
        }

        public Account ToAccount
        {
            get; set;
        }

        public decimal Amount
        {
            get;set;
        }

        public string TransCode
        {
            get;set;
        }

    }
}
