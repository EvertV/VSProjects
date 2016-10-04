using System;

namespace Banking.Models
{
    public class Transaction
    {
        public decimal Amount { get; private set; }
        public DateTime DateOfTrans { get; private set; }
        public TransactionType TransactionType { get; private set; }
        public bool IsWithdraw
        {
            get { return TransactionType == TransactionType.Withdraw; }
        }

        public bool IsDeposit
        {
            get { return TransactionType == TransactionType.Deposit; }
        }

        public Transaction(decimal amount, TransactionType transactionType)
        {
            Amount = amount;
            DateOfTrans = DateTime.Now;
            TransactionType = transactionType;
        }


    }
}
