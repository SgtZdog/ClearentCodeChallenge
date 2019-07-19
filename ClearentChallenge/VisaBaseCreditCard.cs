namespace ClearentChallenge
{
    public class VisaBaseCreditCard : CreditCard
    {
        public VisaBaseCreditCard() : this(decimal.Zero)
        {
        }

        internal VisaBaseCreditCard(decimal startingBalance) :
            base("Visa", (decimal) .1, startingBalance)
        {
        }

        public override decimal NextInterestIncrement => CurrentBalance * InterestRate;

        public override void AddInterest()
        {
            CurrentBalance += NextInterestIncrement;
        }
    }
}