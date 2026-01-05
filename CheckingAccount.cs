using System;
using Bank_Account;

public class CheckingAccount : BankAccount
{
    private decimal _overdraftLimit = 1100m;
    public string AccountHolderName { get; set; }
    public string AccountNumber { get; set; } = "ACC123456";  // Or generate it

    public decimal OverdraftLimit
    {
        get => _overdraftLimit;
        set
        {
            if (value < 0m) throw new ArgumentOutOfRangeException(nameof(value), "Overdraft limit cannot be negative.");
            _overdraftLimit = value;
        }
    }

  
    public CheckingAccount(string name, decimal initialBalance, decimal overdraftLimit = 1100m)
    : base(name, initialBalance)
{
    OverdraftLimit = overdraftLimit;
    AccountHolderName = name;
    // ... rest if needed
}

    public new void Withdraw(decimal amount)
    {
        if (amount <= 0m)
            throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal amount must be positive.");

        decimal tentativeBalance = Balance - amount;

        if (tentativeBalance < -OverdraftLimit)
            throw new InvalidOperationException($"Withdrawal denied: would exceed overdraft limit of {OverdraftLimit}.");

        Balance = tentativeBalance;
    }
}