using System;

namespace ClearentChallenge
{
    public static class CreditCardFactory
    {
        public static CreditCard CreateCard<TCreditCardType>(decimal startingBalance = decimal.Zero)
            where TCreditCardType : CreditCard, new()
        {
            var creditCard = new TCreditCardType();
            creditCard.AddToBalance(startingBalance);
            return creditCard;
        }
    }
}