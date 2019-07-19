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
            person.AddWallet();
            person.ContainedWallets[0].AddCard(CreditCardFactory.CreateCard<VisaBaseCreditCard>(100));
            person.ContainedWallets[0].AddCard(CreditCardFactory.CreateCard<MCBaseCreditCard>(100));
            person.ContainedWallets[0].AddCard(CreditCardFactory.CreateCard<DiscoverBaseCreditCard>(100));
            Assert.AreEqual((decimal) 16, person.DetermineTotalInterestNextIncrement());
            Assert.AreEqual((decimal) 10, person.ContainedWallets[0].ContainedCards[0].NextInterestIncrement);
            Assert.AreEqual((decimal) 5, person.ContainedWallets[0].ContainedCards[1].NextInterestIncrement);
            Assert.AreEqual((decimal) 1, person.ContainedWallets[0].ContainedCards[2].NextInterestIncrement);
        }

        [Test]
        public void Test2()
        {
            var person = new Person();
            person.AddWallet();
            person.ContainedWallets[0].AddCard(CreditCardFactory.CreateCard<VisaBaseCreditCard>(100));
            person.ContainedWallets[0].AddCard(CreditCardFactory.CreateCard<DiscoverBaseCreditCard>(100));
            person.AddWallet();
            person.ContainedWallets[1].AddCard(CreditCardFactory.CreateCard<MCBaseCreditCard>(100));
            Assert.AreEqual((decimal) 16, person.DetermineTotalInterestNextIncrement());
            Assert.AreEqual((decimal) 11, person.ContainedWallets[0].DetermineTotalInterestNextIncrement());
            Assert.AreEqual((decimal) 5, person.ContainedWallets[1].DetermineTotalInterestNextIncrement());
        }

        [Test]
        public void Test3()
        {
            var person1 = new Person();
            var person2 = new Person();
            person1.AddWallet();
            person1.ContainedWallets[0].AddCard(CreditCardFactory.CreateCard<MCBaseCreditCard>(100));
            person1.ContainedWallets[0].AddCard(CreditCardFactory.CreateCard<VisaBaseCreditCard>(100));
            person2.AddWallet();
            person2.ContainedWallets[0].AddCard(CreditCardFactory.CreateCard<VisaBaseCreditCard>(100));
            person2.ContainedWallets[0].AddCard(CreditCardFactory.CreateCard<MCBaseCreditCard>(100));
            Assert.AreEqual((decimal) 15, person1.DetermineTotalInterestNextIncrement());
            Assert.AreEqual((decimal) 15, person2.DetermineTotalInterestNextIncrement());
            Assert.AreEqual((decimal) 15, person1.ContainedWallets[0].DetermineTotalInterestNextIncrement());
            Assert.AreEqual((decimal) 15, person2.ContainedWallets[0].DetermineTotalInterestNextIncrement());
        }
    }
}