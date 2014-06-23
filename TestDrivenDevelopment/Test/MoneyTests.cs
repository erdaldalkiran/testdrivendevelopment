namespace Test
{
    using Domain;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    [TestClass]
    public class MoneyTests
    {
        [TestMethod]
        public void Multiply_WithTwo_ANewDollarWithDoubledAmount()
        {
            var fiveDollar = Money.Dollar(5);
            var tenDollar = fiveDollar.Times(2);
            Assert.AreEqual(10, tenDollar.Amount);
        }


        [TestMethod]
        public void Equal_AnotherDollarWithSameAmount_True()
        {
            Assert.AreEqual(Money.Dollar(5), Money.Dollar(5));
        }

        [TestMethod]
        public void Equal_AnotherDollarWithDifferentAmount_False()
        {
            Assert.AreNotEqual(Money.Dollar(10), Money.Dollar(13));
        }

        [TestMethod]
        public void Plus_Add5DollarsTo10Dollars_15Dollars()
        {
            var sum = Money.Dollar(10).Plus(Money.Dollar(5));
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, Currency.Dollar);

            Assert.AreEqual(Money.Dollar(15), reduced);
        }


        [TestMethod]
        public void Equal_FrancWithSameAmount_False()
        {
            Assert.AreNotEqual(Money.Dollar(10), Money.Franc(10));
        }


    }
}
