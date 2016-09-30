using System;
using Banking.Models;

namespace Banking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BankAccount ba = new BankAccount("123-456789-11");
            Console.WriteLine($"Rekening met nummer {ba.AccountNumber} werd aangemaakt.");
            Console.WriteLine($"Balans = {ba.Balance}");
            ba.Deposit(50.00M);
            Console.WriteLine("Er werdt 50,00 EUR gestort.");
            Console.WriteLine($"Balans = {ba.Balance}");
            ba.Withdraw(23.95M);
            Console.WriteLine("Er werdt 23,95 EUR afgehaald.");
            Console.WriteLine($"Balans = {ba.Balance}");
            Console.ReadKey();


        }
    }
}
