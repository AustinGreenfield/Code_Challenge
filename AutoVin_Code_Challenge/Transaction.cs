using System;

namespace AutoVin_Code_Challenge
{
    public class Transaction
    /*
     • Transaction types include: Deposit, Withdraw, and Transfer
     */
    {
        public static Account Deposit(decimal amount, Account Acc)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Deposit of a negative amount is not allowed. Please try a Withdrawal instead.");
            }
            if (amount == 0)
            {
                throw new ArgumentOutOfRangeException("Please enter an amount to deposit.");
            }
            Acc.AccountBalance += amount;

            return Acc;
        }
        
        public static Account Withdraw(decimal amount, Account Acc)
        {
            Acc.AccountBalance = 
            amount > Acc.AccountBalance ?
                throw new ArgumentOutOfRangeException("Declined. Account would overdraw.") :
            amount < 0 ?
                throw new ArgumentOutOfRangeException("Withdrawal of a negative amount is not allowed. Please try a Deposit instead.") :
            amount == 0 ?
                throw new ArgumentOutOfRangeException("Please enter an amount to Withdraw.") :
            (amount > 500 && String.IsNullOrWhiteSpace(Acc.InvestType))! ?
                throw new ArgumentOutOfRangeException("Declined. Individual accounts have a withdrawal limit of 500 dollars.") :
            Acc.AccountBalance - amount;
            return Acc;
        }

        public static Tuple<Account,Account> Transfer(decimal amount, Account from, Account to)
        {
            from = Withdraw(amount, from);
            to = Deposit(amount, to);

            return new Tuple<Account,Account>(from, to);
        }
    }
}
