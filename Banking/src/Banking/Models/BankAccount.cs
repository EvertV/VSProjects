using System;
using System.Collections.Generic;

namespace Banking.Models
{
    public class BankAccount
    {
        #region Attributes
        private string _accountNumber;
        private IList<Transaction> _transactions;
        #endregion

        #region Constructors
        public BankAccount(string accountNumber) : this(accountNumber, 0)
        {
        }

        public BankAccount(string accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            _transactions = new List<Transaction>();
        }
        #endregion

        #region Methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
            _transactions.Add(new Transaction(amount, TransactionType.Deposit));
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
            _transactions.Add(new Transaction(amount, TransactionType.Withdraw));
        }

        public IEnumerable<Transaction> GetTransactions(DateTime? from, DateTime? till)
        {
            if (from == null)
                from = DateTime.MinValue;
            if(till == null) 
                till = DateTime.MaxValue;

            ICollection<Transaction> transactions = new List<Transaction>();
            foreach (Transaction t in _transactions)
            {
                if (t.DateOfTrans > from && t.DateOfTrans < till)
                    transactions.Add(t);
            }
            return transactions;
        }

        #endregion

        #region Properties
        public decimal Balance { get; private set; }

        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public int NumberOfTransactions
        {
            get { return _transactions.Count; }
        }

        #endregion

    }
}
