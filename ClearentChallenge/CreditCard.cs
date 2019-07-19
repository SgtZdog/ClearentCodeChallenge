namespace ClearentChallenge
{
    public abstract class CreditCard
    {
        protected CreditCard(string company, decimal interestRate, bool useSimpleInterest = true,
            decimal startingBalance = decimal.Zero)
        {
            Company = company;
            InterestRate = interestRate;
            UseSimpleInterest = useSimpleInterest;
            CurrentBalance = startingBalance;
        }

        public string Company { get; private set; }
        public decimal InterestRate { get; private set; }
        public bool UseSimpleInterest { get; private set; }
        public decimal CurrentBalance { get; private set; }

        public abstract decimal PredictInterest();
        public abstract void AddInterest();
    }
}