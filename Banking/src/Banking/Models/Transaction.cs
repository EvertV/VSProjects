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

        /// <summary>
        /// Constructor Transaction
        /// </summary>
        /// <param name="amount">amount of transaction</param>
        /// <param name="transactionType">withdraw or deposit</param>
        public Transaction(decimal amount,
            TransactionType transactionType)
        {
            Amount = amount;
            DateOfTrans = DateTime.Now;
            TransactionType = transactionType;
        }


    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Banking.Models
//{
//    public class Transaction
//    {
//        #region Properties

//        public decimal Amount { get; set; }
//        public DateTime DateOfTrans { get; private set; }

//        public bool IsDeposit
//        {
//            get { return TransactionType == TransactionType.Deposit; }
//        }

//        public bool IsWithdraw
//        {
//            get { return TransactionType == TransactionType.Withdraw; }
//        }

//        public TransactionType TransactionType { get; private set; }

//        #endregion
//        #region Contructors
//        public Transaction(decimal amount, TransactionType type)
//        {
//            Amount = amount;
//            TransactionType = type;
//            DateOfTrans = DateTime.Now;
//        } 
//        #endregion
//    }
//}
