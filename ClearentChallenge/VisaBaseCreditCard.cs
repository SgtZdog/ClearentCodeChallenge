namespace ClearentChallenge
{
    public class VisaBaseCreditCard : CreditCard
    {
        internal VisaBaseCreditCard(decimal startingBalance = decimal.Zero) :
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