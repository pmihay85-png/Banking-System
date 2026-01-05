using System;

namespace Bank_Account
{
    public class BankAccount
    {
        private string AccountNumber { get; } = new Random().Next(100000, 999999).ToString();
        private string AccountHolderName { get; set; }
        //protected decimal Balance { get; set; }
        public decimal Balance { get; protected set; }

        public BankAccount(string name, decimal initialBalance)
        {
            AccountHolderName = name;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0) Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance) Balance -= amount;
            return;
        }

        public override string ToString()
        {
            return $"bankAccount: AccountNumber: {AccountNumber}, {AccountHolderName}: {Balance:C}";
        }

    }
}
