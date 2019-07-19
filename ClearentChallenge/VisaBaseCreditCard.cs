namespace ClearentChallenge
{
    public class VisaBaseCreditCard : CreditCard
    {
        private CreditCard _creditCardImplementation;

        internal VisaBaseCreditCard() :
            base("Visa", (decimal) .1, useSimpleInterest: true, startingBalance: 0)
        {
        }

        public override decimal PredictInterest()
        {
            throw new System.NotImplementedException();
        }

        public override void AddInterest()
        {
            throw new System.NotImplementedException();
        }
    }
}