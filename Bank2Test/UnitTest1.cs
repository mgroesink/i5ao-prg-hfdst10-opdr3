using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank2;

namespace Bank2Test
{
    [TestClass]
    public class Bank2Test
    {
        [TestMethod]
        public void DepositTest()
        {
            BankAccount br = new BankAccount(0);
            double expectedresult = 1000;
            br.Deposit(1000);
            Assert.AreEqual(br.CurrentBalance, expectedresult);
        }

        [TestMethod]
        public void WithdrawTest()
        {
            BankAccount br = new BankAccount(10000);
            double expectedresult = 9000;
            br.WithDraw(1000);
            Assert.AreEqual(br.CurrentBalance, expectedresult);

        }

        [TestMethod]
        [ExpectedException(typeof(BalanceTooLowException), "The balance is too low.")]
        public void BalanceTooLowTest()
        {
            BankAccount br = new BankAccount(0);
            br.WithDraw(1000);
        }

    }
}
