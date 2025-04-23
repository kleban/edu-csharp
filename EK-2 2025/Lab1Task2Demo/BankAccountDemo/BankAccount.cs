using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountDemo
{
    //Реалізуйте клас `BankAccount`, який має:
    //+ Приватне поле `_balance`, що зберігає баланс рахунку.
    //+ Властивість `Balance`, яка дозволяє тільки зчитувати значення балансу.
    //+ Конструктор, який ініціалізує баланс рахунку початковою сумою.
    //+ Метод `Deposit(decimal amount)`, який додає гроші на рахунок (якщо `amount` більше 0).
    //+ Метод `Withdraw(decimal amount)`, який знімає гроші з рахунку(якщо `amount` більше 0 і достатньо коштів).
    //- В методі `Main()` створіть екземпляр класу `BankAccount`, зробіть кілька операцій зняття та поповнення, виведіть баланс у консоль.
    public class BankAccount
    {
        private double _balance = 0;
        private double _withdrawLimit = 0;
        private string[] _transactionHistory;
        public BankAccount(double initBalance, double withdrawLimit = 0)
        {
            if (initBalance > 0)
                _balance = initBalance;
            _withdrawLimit = withdrawLimit;
            _transactionHistory = new string[0];
        }

        public double Balance => _balance;

        public bool Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                addTransaction($"Поповнення: +{amount} грн");
                return true;
            }
            return false;
        }

        private void addTransaction(string transaction)
        {
            List<string> transactions = new List<string>(_transactionHistory);
            transactions.Add(transaction);
            _transactionHistory = transactions.ToArray();
        }

        public bool Withdraw(double amount)
        {
            if (amount > 0 && _balance >= amount)
            {
                if (amount <= _withdrawLimit)
                {
                    _balance -= amount;
                    addTransaction($"Зняття: -{amount} грн");
                    return true;
                }
                else
                {
                    addTransaction($"Перевищення ліміту на зняття: - {amount} vs {_withdrawLimit} грн");
                    Console.WriteLine("Withdraw limit exceeded!");
                }
            }

            else
            {
                addTransaction($"Недостатньо коштів для зняття: - {amount} vs {_balance} грн");
                Console.WriteLine("No money!");
            }
            return false;
        }

        public void PrintTransactionHistory()
        {
            Console.WriteLine("-----TRANSACTIONS-----");
            foreach (var transaction in _transactionHistory)
            {
                Console.WriteLine(transaction);
            }
            Console.WriteLine("---------------------");
        }
        //+ Додайте приватне поле `_withdrawLimit` (ліміт на зняття за одну операцію).
        //+ Додайте у конструктор параметр `withdrawLimit`, який встановлює цей ліміт.
        //+ При виклику `Withdraw(amount)`, якщо `amount` перевищує ліміт, виводьте повідомлення про обмеження.
        //- Додайте колекцію типу `string _transactionHistory`, де зберігатимуться всі операції.
        //- Після кожного `Deposit` або `Withdraw` додавайте запис у форматі:
        //- `"Поповнення: +500 грн"`
        //- `"Зняття: -200 грн"`
        //- Додайте метод `PrintTransactionHistory()`, який виводить всі операції на екран.
    }
}
