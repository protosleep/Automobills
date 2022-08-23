using Microsoft.VisualStudio.TestTools.UnitTesting;
using Automobills.Core.Accounts;
using Automobills.Core.Transactions;

namespace Automobills.Core.Test.Accounts
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void PaycheckTest()
        {
            DebitAccount da = new();
            da.InitialBalance = 50.0;

            Deposit paycheck = new();
            paycheck.Amount = 1000.0;
            paycheck.Source = new ExternalAccount();
            paycheck.Destination = da;

            paycheck.Apply();

            double expectedBalance = 1050.0;

            Assert.AreEqual(expectedBalance, da.Balance);

        }
    }
}
