using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoVin_Code_Challenge;
using System;

namespace Testing
{
    [TestClass]
    public class UnitTestDeposits
    {

        //postive tests
        [TestMethod]
        public void TestDeposit1_one_dollar()
        {
            Account TstStart = new Account(99, "", "", "Test", 15);
            Account TstFinish = Transaction.Deposit((decimal)1, TstStart);

            Assert.AreEqual(16, TstFinish.AccountBalance, "Test failed, unable to Deposit 1 dollar.");
        }

        [TestMethod]
        public void TestDeposit2_one_hundred_dollars()
        {
            Account TstStart = new Account(99, "", "", "Test", 15);
            Account TstFinish = Transaction.Deposit((decimal)100, TstStart);

            Assert.AreEqual(115, TstFinish.AccountBalance, "Test failed, unable to Deposit 100 dollars.");
        }

        //negative tests
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Please enter an amount to deposit.")]
        public void TestWithdrawal3_zero_dollars()
        {
            Account TstStart = new Account(98, "", "", "Test2", 1115);
            Account TstFinish = Transaction.Deposit((decimal)0, TstStart);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Deposit of a negative amount is not allowed. Please try a Withdrawal instead.")]
        public void TestWithdrawal4_less_zero_dollars()
        {
            Account TstStart = new Account(98, "", "", "Test2", 1115);
            Account TstFinish = Transaction.Deposit((decimal)-1, TstStart);
        }
    }
}
