using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoVin_Code_Challenge;
using System.Collections.Generic;
using System;

namespace Testing
{
    [TestClass]
    public class UnitTestWithdrawals
    {
        //postive test cases        
        [TestMethod]
        public void TestWithdrawal1_one_dollar()
        {
            Account TstStart = new Account(99, "", "", "Test", 15);
            Account TstFinish = Transaction.Withdraw((decimal)1, TstStart);

            Assert.AreEqual(14, TstFinish.AccountBalance, "Test failed, unable to withdraw 1 dollar.");
        }

        [TestMethod]
        public void TestWithdrawal2_one_hundred_dollars()
        {
            Account TstStart = new Account(98, "", "", "Test2", 1115);
            Account TstFinish = Transaction.Withdraw((decimal)100, TstStart);

            Assert.AreEqual(1015, TstFinish.AccountBalance, "Test failed, unable to withdraw 100 dollars.");
        }

        //negative test cases
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Declined. Individual accounts have a withdrawal limit of 500 dollars.")]
        public void TestWithdrawal3_five_hundred_and_one_dollars()
        {
            Account TstStart = new Account(98, "", "", "Test2", 1115);
            Account TstFinish = Transaction.Withdraw((decimal)501, TstStart);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Please enter an amount to Withdraw.")]
        public void TestWithdrawal4_zero_dollars()
        {
            Account TstStart = new Account(98, "", "", "Test2", 1115);
            Account TstFinish = Transaction.Withdraw((decimal)0, TstStart);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Withdrawal of a negative amount is not allowed. Please try a Deposit instead.")]
        public void TestWithdrawal5_less_zero_dollars()
        {
            Account TstStart = new Account(98, "", "", "Test2", 1115);
            Account TstFinish = Transaction.Withdraw((decimal)-1, TstStart);
        }
    }
}
