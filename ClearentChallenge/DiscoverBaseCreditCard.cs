using System;

namespace ClearentChallenge
{
    public class DiscoverBaseCreditCard : CreditCard
    {
        public DiscoverBaseCreditCard() : this(decimal.Zero)
        {
        }

        internal DiscoverBaseCreditCard(decimal startingBalance) :
            base("Discover", (decimal) .01, startingBalance)
        {
        }

        public override decimal NextInterestIncrement => CurrentBalance * InterestRate;

        public override void AddInterest()
        {
            CurrentBalance += NextInterestIncrement;
        }
    }
}