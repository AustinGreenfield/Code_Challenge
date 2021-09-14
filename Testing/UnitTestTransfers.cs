using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoVin_Code_Challenge;
using System;

namespace Testing
{
    [TestClass]
    public class UnitTestTransfers
    {
       
        //postive test cases
        [TestMethod]
        public void TestTransfer1_one_hundred_dollars()
        {
            Account TstStart1 = new Account(98, "", "", "Test1", 1115); //from
            Account TstStart2 = new Account(98, "", "", "Test2", 115); //to
            Tuple<Account, Account> TstFinish = Transaction.Transfer((decimal)100, TstStart1, TstStart2);

            Assert.AreEqual(1015, TstFinish.Item1.AccountBalance, "Test failed, unable to transfer 100 dollars.");
            Assert.AreEqual(215, TstFinish.Item2.AccountBalance, "Test failed, unable to transfer 100 dollars.");
        }

        [TestMethod]
        public void TestTransfer2_one_dollar()
        {
            Account TstStart1 = new Account(98, "", "", "Test1", 1115); //from
            Account TstStart2 = new Account(98, "", "", "Test2", 115); //to
            Tuple<Account, Account> TstFinish = Transaction.Transfer((decimal)1, TstStart1, TstStart2);

            Assert.AreEqual(1114, TstFinish.Item1.AccountBalance, "Test failed, unable to transfer 1 dollar.");
            Assert.AreEqual(116, TstFinish.Item2.AccountBalance, "Test failed, unable to transfer 1 dollar.");
        } 


        //negative test cases
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Declined. Individual accounts have a withdrawal limit of 500 dollars.")]
        public void TestTransfer3_zero_dollars()
        {
            Account TstStart1 = new Account(98, "", "", "Test1", 1115);
            Account TstStart2 = new Account(98, "", "", "Test2", 115);
            Tuple<Account,Account> TstFinish1 = Transaction.Transfer((decimal)550, TstStart1, TstStart2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Withdrawal of a negative amount is not allowed. Please try a Deposit instead.")]
        public void TestTransfer4_less_than_zero()
        {
            Account TstStart1 = new Account(98, "", "", "Test1", 1115);
            Account TstStart2 = new Account(98, "", "", "Test2", 115);
            Tuple<Account, Account> TstFinish1 = Transaction.Transfer((decimal)-1, TstStart1, TstStart2);
        }
    }
}
