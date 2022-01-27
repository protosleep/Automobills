using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Automobills.Data
{
    class TransactionList
    {
        private DataSet mDataset = new DataSet();

        public TransactionList()
        {
            Transactions = new List<Transaction>();
        }

        public void LoadTransactions(DatabaseInterface dbif, long accountId, AccountList accountList)
        {
            Transactions.Clear();

            string query = "select * from CHECKINGACCOUNT_V1 where ACCOUNTID = '" + accountId.ToString() + "'";
            dbif.GetData(ref mDataset, query);
            DataTable table = mDataset.Tables[0];

            foreach (DataRow r in table.Rows)
            {
                Transaction t = new Transaction(r, accountList);
                Transactions.Add(t);
            }
        }

        public List<Transaction> Transactions
        {
            get;set;
        }
    }
}
