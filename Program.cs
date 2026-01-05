using System;
using Bank_Account;

class Program
{
 
        static void Main()
        {
            Console.WriteLine("Welcome to the Banking System!\n");

            // Account selection
            Console.WriteLine("Choose an account type:");
            Console.WriteLine("1. Savings Account");
            Console.WriteLine("2. Checking Account");
            Console.WriteLine("3.Apply Interest");
            Console.WriteLine("4.Exit");    
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            Console.Write("Enter account holder name: ");
            string name = Console.ReadLine();
            Console.Write("Enter initial deposit amount: ");
            decimal initialBalance = decimal.Parse(Console.ReadLine());
            Console.Write("Enter interest rate (e.g., 5 for 5%): ");
            decimal interestRate = decimal.Parse(Console.ReadLine()) / 100m;

            // Create account (Savings for choice "1")
            SavingsAccount account = new SavingsAccount(name, initialBalance, interestRate);

            Console.WriteLine("\nAccount created successfully!");
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Account Holder: {account.AccountHolderName}");
            Console.WriteLine($"Balance: {account.Balance:C}\n");

            // Main transaction loop
            while (true)
            {
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Apply Interest");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string action = Console.ReadLine();

                if (action == "4")
                {
                    Console.WriteLine("\nThank you for using the Banking System!");
                    return;
                }

                if (action == "1")
                {
                    Console.Write("Enter deposit amount: ");
                    decimal depositAmt = decimal.Parse(Console.ReadLine());
                    (new DepositTransaction(account, depositAmt)).Execute();
                    Console.WriteLine("Transaction successful!");
                    Console.WriteLine($"Updated Balance: {account.Balance:C}\n");
                }
                else if (action == "2")
                {
                    Console.Write("Enter withdraw amount: ");
                    decimal withdrawAmt = decimal.Parse(Console.ReadLine());
                    try
                    {
                        (new WithdrawTransaction(account, withdrawAmt)).Execute();
                        Console.WriteLine("Transaction successful!");
                        Console.WriteLine($"Updated Balance: {account.Balance:C}\n");
                    }
                    catch
                    {
                        Console.WriteLine("Transaction failed - insufficient funds!\n");
                    }
                }
                else if (action == "3")
                {
                    decimal interest = account.ApplyInterest();
                    Console.WriteLine("Interest applied successfully!");
                    Console.WriteLine($"Updated Balance: {account.Balance:C}\n");
                }
            }
        }
    }

    
    









