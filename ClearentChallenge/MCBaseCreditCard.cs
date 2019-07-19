using System;

namespace ClearentChallenge
{
    public class MCBaseCreditCard : CreditCard
    {
        public MCBaseCreditCard() : this(decimal.Zero)
        {
        }

        internal MCBaseCreditCard(decimal startingBalance) :
            base("MC", (decimal) .05, startingBalance)
        {
        }

        public override decimal NextInterestIncrement => CurrentBalance * InterestRate;

        public override void AddInterest()
        {
            CurrentBalance += NextInterestIncrement;
        }
    }
}