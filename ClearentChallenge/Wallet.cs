using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ClearentChallenge
{
    public class Wallet
    {
        private readonly List<CreditCard> _containedCards = new List<CreditCard>();
        public ReadOnlyCollection<CreditCard> ContainedCards => _containedCards.AsReadOnly();

        public decimal DetermineTotalInterestNextIncrement()
        {
            return ContainedCards.Select(card => card.NextInterestIncrement).Sum();
        }

        public void AddCard(CreditCard creditCard)
        {
            _containedCards.Add(creditCard);
        }
    }
}