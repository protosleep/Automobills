using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;


namespace Automobills.Data
{
    class DatabaseInterface
    {
        private SQLiteConnection mSqlConnection;
        private SQLiteDataAdapter mDBAdaptor;
        private string mConnectionString;

        public DatabaseInterface(string filename)
        {
            bool create = !File.Exists(filename);

            mConnectionString = "Data Source=" + filename + ";Version=3;New=";
            mConnectionString += create ? "True" : "False";                
            mConnectionString += ";Compress=False;";

            if (create)
            {
                mSqlConnection = new SQLiteConnection(mConnectionString);
                mSqlConnection.Open();
                mSqlConnection.Close();
            }
        }
        
        public void GetData(ref DataSet dataset, string query)
        {
            mSqlConnection = new SQLiteConnection(mConnectionString);
            mSqlConnection.Open();
            SQLiteCommand command = mSqlConnection.CreateCommand();
            mDBAdaptor = new SQLiteDataAdapter(query, mSqlConnection);
            dataset.Reset();
            mDBAdaptor.Fill(dataset);
            mSqlConnection.Close();
        }

        public void ExecuteNonQuery(string textQuery)
        {
            mSqlConnection = new SQLiteConnection(mConnectionString);
            mSqlConnection.Open();
            SQLiteCommand command = mSqlConnection.CreateCommand();
            command.CommandText = textQuery;
            command.ExecuteNonQuery();
            mSqlConnection.Close();
        }
    }
}
