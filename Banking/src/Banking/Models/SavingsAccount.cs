namespace Banking.Models
{
    public class SavingsAccount : BankAccount
    {
        public const decimal WitdrawCost = 0.25M;

        public decimal InterestRate { get; set; }

        public SavingsAccount(string accountNumber, decimal interestRate) : 
            this(accountNumber,0, interestRate)
        {
        }

        public SavingsAccount(string accountNumber, decimal balance, decimal interestRate) : base(accountNumber, balance)
        {
            InterestRate = interestRate;
        }

        public void AddInterest()
        {
            Deposit(Balance * InterestRate);
        }

        public override void Withdraw(decimal amount)
        {
            base.Withdraw(amount);
            base.Withdraw(WitdrawCost);
        }
    }
}
