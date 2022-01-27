using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Automobills.Data
{
    class AccountList
    {
        private DataSet mDataset = new DataSet();
        private DataTable mTable;
        

        public void LoadAccounts(DatabaseInterface dbif)
        {
            Accounts = new List<Account>();
            Accounts.Clear();

            string query = "select * from ACCOUNTLIST_V1";
            dbif.GetData(ref mDataset, query);
            mTable = mDataset.Tables[0];

            foreach (DataRow r in mTable.Rows)
            {
                Account a = new Account(r);
                Accounts.Add(a);
            }
        }


        public void LoadTransactions(DatabaseInterface dbif)
        {
            foreach (Account a in Accounts)
            {
                a.LoadTransactions(dbif, this);
            }
        }

        public List<Account> Accounts
        {
            get;set;
        }

    }
}
