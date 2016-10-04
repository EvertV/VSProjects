using System;
using System.Collections.Generic;
using Banking.Models;

namespace Banking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BankAccount account = new BankAccount("123-4567890-02");
            Console.WriteLine($"Balance: {account.Balance}");
            account.Deposit(200);
            Console.WriteLine($"Balance: {account.Balance}");
            account.Withdraw(100);
            Console.WriteLine($"Balance: {account.Balance}");
            Console.WriteLine($"Number of transactions: {account.NumberOfTransactions}");
            IEnumerable<Transaction> transactions = account.GetTransactions(DateTime.Now.AddDays(-2), null);
            foreach (Transaction t in transactions)
            {
                Console.WriteLine($"Transaction on {t.DateOfTrans} : {t.Amount} euro - {t.TransactionType}");
            }
            BankAccount s = new SavingsAccount("123-456789-03", 0.01M);
            Console.WriteLine($"Balance: {s.Balance}");
            s.Deposit(2000);
            Console.WriteLine($"Balance: {s.Balance}");
            s.Withdraw(150);
            Console.WriteLine($"Balance: {s.Balance}");
            (s as SavingsAccount).AddInterest();
            Console.WriteLine($"Balance: {s.Balance}");
            Console.ReadKey();
        }
    }
}
