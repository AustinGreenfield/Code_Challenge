using System;
using System.Collections.Generic;

namespace AutoVin_Code_Challenge
{
    class MainProgram
    {
        /*
            • Individual accounts have a withdrawal limit of 500 dollars.
            • Transactions are made on accounts.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Friends Bank!");
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("Collecting Account Info...");
            Console.WriteLine();
            Console.WriteLine("Account List >>>");
            List<Account> Accounts = Account.GenerateInitialAccounts();
            foreach (Account Acc in Accounts)
            {
                Console.WriteLine(Acc.ToString());
            }

            Console.WriteLine("Initiating Transactions on Accounts...");
            Console.WriteLine();
            Console.WriteLine("Running next five transactions.");
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Transaction "+i+" in progress");
                try
                {
                    Console.WriteLine(Accounts[i].ToString());
                    Accounts[i] = TransactionRuns(i, Accounts[i]);
                    Console.WriteLine("Account Updated >>>");
                    Console.WriteLine(Accounts[i].ToString());
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e);
                }

                Console.WriteLine("Transaction completed.");
                Console.WriteLine(); Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("All Transactions Finished.");

            Console.WriteLine("Updated Account List >>>");
            foreach (Account Acc in Accounts)
            {
                Console.WriteLine(Acc.ToString());
            }

            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Goodbye.");
        }

        static dynamic TransactionRuns(int transaction, Account Acct, Account Acct2 = null)
        {
            // Just a few transactions

            if (transaction == 1)
            {
                //Withdraw $350.25 from individual account
                Account AcctTrans = Transaction.Withdraw((decimal)350.25,Acct);
                return AcctTrans;
            }
            if (transaction == 2)
            {
                //Withdraw $50.00 from individual account
                Account AcctTrans = Transaction.Withdraw((decimal)50.01, Acct);
                return AcctTrans;
            }
            if (transaction == 3)
            {
                //Withdraw $4000 from Corporate account
                Account AcctTrans = Transaction.Withdraw((decimal)4000.02, Acct);
                return AcctTrans;
            }
            if (transaction == 4)
            {
               //Deposit $200.99 to individual account
                Account AcctTrans = Transaction.Deposit((decimal)200.99, Acct);
                return AcctTrans;
            }
            if (transaction == 5)
            {
                //Deposit $2 to investment individual account
                Account AcctTrans = Transaction.Deposit((decimal)2.19, Acct);
                return AcctTrans;
            }
            else
            return null;
        }
    }

}
