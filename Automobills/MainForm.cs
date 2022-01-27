using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automobills.Data;
using Automobills.GUI;
using Microsoft.VisualBasic.FileIO;

namespace Automobills
{
    public partial class MainForm : Form
    {
        private AccountList mList = new AccountList();
        private TransactionPanel mTransactionPanel;
        private ControlPanel mControlPanel;

        public MainForm()
        {
            InitializeComponent();
            mControlPanel = new ControlPanel();
            mTransactionPanel = new TransactionPanel();

            mControlPanel.Location = new Point(0, 0);
            mTransactionPanel.Location = new Point(mControlPanel.Width + 2, 0);
            mTransactionPanel.Size = new Size(this.Width - mControlPanel.Width, this.Height);

            this.Controls.Add(mControlPanel);
            this.Controls.Add(mTransactionPanel);


            //string filename = "Finance2.mmb";
            //if (System.IO.File.Exists(filename))
            //{
            //    DatabaseInterface db = new DatabaseInterface(filename);
            //    mList.LoadAccounts(db);
            //    mList.LoadTransactions(db);
            //}            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
