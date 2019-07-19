using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ClearentChallenge
{
    public class Person
    {
        private readonly List<Wallet> _containedWallets = new List<Wallet>();
        public ReadOnlyCollection<Wallet> ContainedWallets => _containedWallets.AsReadOnly();

        public decimal DetermineTotalInterestNextIncrement()
        {
            return ContainedWallets.Select(wallet => wallet.DetermineTotalInterestNextIncrement()).Sum();
        }

        public void AddWallet()
        {
            _containedWallets.Add(new Wallet());
        }
    }
}