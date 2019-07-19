using System;
using System.Collections.Generic;
using System.Linq;

namespace ClearentChallenge
{
    public class Person
    {
        public List<Wallet> ContainedWallets { get; } = new List<Wallet>();

        public decimal DetermineTotalInterestNextIncrement()
        {
            return ContainedWallets.Select(wallet => wallet.DetermineTotalInterestNextIncrement()).Sum();
        }
    }
}