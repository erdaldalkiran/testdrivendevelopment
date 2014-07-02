using System.Linq.Expressions;

namespace Domain.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MoneyTests
    {

        [TestMethod]
        public void Multiplication_MultiplyWith2_DoubledAmount()
        {
            Money fiveDollar = Money.Dollar(5);

            Assert.AreEqual(Money.Dollar(10), fiveDollar.Times(2));
            Assert.AreEqual(Money.Dollar(5), fiveDollar);
        }


        [TestMethod]
        public void Equals_CompareWithSameAmount_MustBeEqual()
        {
            Assert.AreEqual(Money.Dollar(5), Money.Dollar(5));
        }

        [TestMethod]
        public void Equals_CompareWithDifferentAmount_NotEqual()
        {
            Assert.AreNotEqual(Money.Dollar(5), Money.Dollar(6));
        }


        [TestMethod]
        public void Equals_CompareWithFranc_NotEqual()
        {
            Assert.AreNotEqual(Money.Dollar(5), Money.Franc(5));
        }

        
        [TestMethod]
        public void Plus_Add5DolarsTo6Dolars_11Dolars()
        {
            var sum = Money.Dollar(5).Plus(Money.Dollar(6));
            var bank = new Bank();
            var reduced = bank.Reduce(sum, Currency.Dollar);

            Assert.AreEqual(Money.Dollar(11),reduced);
        }

        
        [TestMethod]
        public void Plus_ReturnsSum()
        {
            var fiveDollars = Money.Dollar(5);
            var result = fiveDollars.Plus(fiveDollars);
            var sum = (Sum) result;

            Assert.AreEqual(Money.Dollar(5), sum.Augend);
            Assert.AreEqual(Money.Dollar(5),sum.Addend);
        }
        
        
    }
}