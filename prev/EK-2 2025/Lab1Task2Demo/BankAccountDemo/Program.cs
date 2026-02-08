
using BankAccountDemo;

BankAccount account = new BankAccount(1000, 400);
account.Deposit(500);
account.Withdraw(300);
account.Withdraw(500);
account.Withdraw(2500);
account.Deposit(300);
account.Withdraw(200);
account.Deposit(100);
Console.WriteLine(account.Balance);

account.PrintTransactionHistory();
