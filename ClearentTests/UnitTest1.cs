using ClearentChallenge;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var person = new Person();
            person.ContainedWallets.Add(new Wallet());
            person.ContainedWallets[0].ContainedCards.Add(CreditCardFactory.CreateCard<VisaBaseCreditCard>(100));
            Assert.AreEqual((decimal) 10, person.DetermineTotalInterestNextIncrement());
        }
    }
}