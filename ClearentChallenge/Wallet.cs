using System.Collections.Generic;
using System.Linq;

namespace ClearentChallenge
{
    public class Wallet
    {
        public List<CreditCard> ContainedCards { get; } = new List<CreditCard>();

        public decimal DetermineTotalInterestNextIncrement()
        {
            return ContainedCards.Select(card => card.NextInterestIncrement).Sum();
        }
    }
}