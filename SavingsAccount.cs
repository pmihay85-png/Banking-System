using System;

namespace Bank_Account
{
    internal class SavingsAccount : BankAccount
    {
        private decimal InterestRate;
        public string AccountNumber { get; } = "ACC" + new Random().Next(100000, 999999);
        public string AccountHolderName { get; set; }


        public SavingsAccount(string name, decimal initialBalance, decimal interestRate)
            : base(name, initialBalance)
        {
            InterestRate = interestRate;
            AccountHolderName = name;
        }

        // Apply interest, deposit the interest to the account, and return the interest amount applied
        public decimal ApplyInterest()
        {
            // Requires BankAccount.Balance to be accessible (protected) or a public GetBalance()
            decimal interestAmount = Balance * InterestRate;
            if (interestAmount > 0)
                Deposit(interestAmount);
            return interestAmount;
        }
    }
}