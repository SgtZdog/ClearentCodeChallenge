namespace ClearentChallenge
{
    public class CreditCardType
    {
        public CreditCardType(string company, decimal interestRate, bool useSimpleInterest = true)
        {
            Company = company;
            InterestRate = interestRate;
            UseSimpleInterest = useSimpleInterest;
        }

        public string Company { get; private set; }

        public decimal InterestRate { get; private set; }

        public bool UseSimpleInterest { get; private set; }
    }
}