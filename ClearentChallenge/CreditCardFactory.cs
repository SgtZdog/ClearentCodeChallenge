using System;

namespace ClearentChallenge
{
    public class CreditCardFactory
    {
        public CreditCard CreateCard<TCreditCardType>() where TCreditCardType : CreditCard, new()
        {
            return new TCreditCardType();
        }
    }
}