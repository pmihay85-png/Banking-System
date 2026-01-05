This Project is to design a simple **Banking System** that manages accounts for customers. 
The system should allow users to create different types of bank accounts, perform transactions (deposit and withdraw), and display account details.

Welcome to the Banking System!

Choose an account type:
1. Savings Account
2. Checking Account
3.Apply Interest
4.Exit
Enter your choice


During implementation several core principles of Object-Oriented Programming (OOP) has been applied:
- **Encapsulation**, **Inheritance**, **Polymorphism**, and **Abstraction**

**BANKACCOUNTPROGRAM**

| Principle     | Implementation                              |
| ------------- | ------------------------------------------- |
| Encapsulation | private fields, protected set               |
| Polymorphism  | override ToString()                         |
| Abstraction   | Public Deposit()/Withdraw() hide complexity |


**CHECKING ACCOUNT:**

CheckingAccount : BankAccount **inherits** Balance, Deposit(), base ToString(), and constructor logic.

**Polymorphism - Method Hiding**
public new void Withdraw(decimal amount)  // ← '**new**' keyword hides base method

| Principle     | Implementation                             |
| ------------- | ------------------------------------------ |
| Inheritance   | : BankAccount                              |
| Polymorphism  | new void Withdraw() (hiding)               |
| Encapsulation | Private field + validating property        |
| Abstraction   | OverdraftLimit property hides setter logic |

**SAVING ACCOUNT**

| Principle     | Implementation in Code         |
| ------------- | ------------------------------ |
| Inheritance   | : BankAccount                  |
| Encapsulation | private decimal InterestRate   |
| Abstraction   | public decimal ApplyInterest() |


**TRANSACTION**
**Inheritance**
DepositTransaction and WithdrawTransaction inherit from abstract Transaction base class, gaining protected Account field and constructor validation.

**Polymorphism**
Abstract Execute() method overridden differently in each derived class:

DepositTransaction calls Account.Deposit()

WithdrawTransaction calls Account.Withdraw()

Runtime polymorphism: Transaction tx = new DepositTransaction(...); tx.Execute(); calls correct override.

**Abstraction**
Transaction defines contract (Execute()) without implementation - derived classes must provide specifics.

**Encapsulation**
protected readonly Account - accessible only within hierarchy, immutable after construction

Constructor validates account != null
Amount public fields could use properties for better encapsulation

OOP Principles Table
Principle	Implementation
**Inheritance**	: Transaction
**Polymorphism**	override void Execute()
**Abstraction**	abstract class Transaction
**Encapsulation**	protected readonly Account
