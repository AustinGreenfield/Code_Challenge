using System;
using System.Collections.Generic;

namespace AutoVin_Code_Challenge
{
    /* 
        • A bank also has several accounts.
        • An account has an owner and a balance.
        • Account types include: Checking, Investment.
        • There are two types of Investment accounts: Individual, Corporate.
        • Individual accounts have a withdrawal limit of 500 dollars.
    */

    // This would typically be a DB query, I'm just generating it here for simplicity.
    public class Account
    {
        private int     AccountID;
        private string  AccountType;
        public string  InvestType;
        private string  AccountOwner;
        public decimal AccountBalance;

        public Account(int Acc_ID, string Acc_Type, string Acc_InvTyp, string Acc_Owner, decimal Acc_Balance)
        {
            AccountID = Acc_ID;
            AccountType = Acc_Type;
            InvestType = Acc_InvTyp;
            AccountOwner = Acc_Owner;
            AccountBalance = Acc_Balance;

        }  

        public override string ToString()
        {
            string AccountString = "\t Account: " + AccountID 
                                 + "\t Owner: " + AccountOwner 
                                 + "\t Type: " + AccountType + (String.IsNullOrWhiteSpace(InvestType)? "\t\t" : "("+InvestType+")")
                                 + "\t Balance: $" + AccountBalance;
            return AccountString;
        }
    

        
        public static List<Account> GenerateInitialAccounts()
        {
            List<Account> Accounts = new List<Account>();
                Accounts.Add(new Account(1, "Checking",     null,           "Joey Tribiani",            (decimal)47.13));
                Accounts.Add(new Account(2, "Checking",     null,           "Monica Geller",            (decimal)1100.57));
                Accounts.Add(new Account(3, "Checking",     null,           "Chandler Bing",            (decimal)3000.39));
                Accounts.Add(new Account(4, "Investment",   "Corporate",    "Central Perk",             (decimal)10000.00));
                Accounts.Add(new Account(5, "Checking",     null,           "Ross Geller",              (decimal)500.15));
                Accounts.Add(new Account(6, "Investment",   "Individual",   "Ross Geller",              (decimal)6000.50));
                Accounts.Add(new Account(7, "Checking",     null,           "Rachel Green",             (decimal)2000.24));
                Accounts.Add(new Account(8, "Checking",     null,           "Phoebe Buffay",            (decimal)700.01));

            return Accounts;
        }
    }
}
