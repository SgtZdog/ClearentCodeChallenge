namespace ClearentChallenge
{
    public abstract class CreditCard
    {
        protected CreditCard(string company, decimal interestRate, decimal startingBalance = decimal.Zero)
        {
            Company = company;
            InterestRate = interestRate;
            CurrentBalance = startingBalance;
        }

        public abstract decimal NextInterestIncrement { get; }

        public string Company { get; }
        public decimal InterestRate { get; }
        public decimal CurrentBalance { get; protected set; }

        public abstract void AddInterest();
    }
}