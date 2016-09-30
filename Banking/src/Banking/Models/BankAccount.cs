using System;

namespace Banking.Models
{
    public class BankAccount
    {
        #region Fields
        private string _accountNumber;
        public const decimal WithdrawCost = 0.25M;
        #endregion
        
        #region Properties
        public string AccountNumber
        {
            get { return _accountNumber; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Accountnumber mag niet null zijn.");
                _accountNumber = value;
            }
        }

        public decimal Balance { get; private set; }
        #endregion
        
        #region Constructors
        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
            Balance = decimal.Zero;
        }

        public BankAccount(string accountNumber, decimal balance) : this(accountNumber)
        {
            Balance = balance;
        }
        #endregion
        
        #region Methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        } 
        #endregion
    }
}
