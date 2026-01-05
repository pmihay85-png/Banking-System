using Bank_Account;

public abstract class Transaction
{
    protected readonly BankAccount Account;

    protected Transaction(BankAccount account)
    {
        Account = account ?? throw new ArgumentNullException(nameof(account));
    }

    public abstract void Execute();
}

public class DepositTransaction : Transaction
{
    public decimal Amount;
    public DepositTransaction(BankAccount account, decimal amount) : base(account)
    {
        Amount = amount;
    }
    public override void Execute() => Account.Deposit(Amount);
}

public class WithdrawTransaction : Transaction
{
    public decimal Amount;
    public WithdrawTransaction(BankAccount account, decimal amount) : base(account)
    {
        Amount = amount;
    }
    public override void Execute() => Account.Withdraw(Amount);
}
