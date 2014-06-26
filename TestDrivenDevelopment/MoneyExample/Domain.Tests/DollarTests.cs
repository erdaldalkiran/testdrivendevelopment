namespace Domain.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DollarTests
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
    }
}