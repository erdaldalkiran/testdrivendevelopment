namespace Domain.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FrancTests
    {

        [TestMethod]
        public void Multiplication_MultiplyWith2_DoubledAmount()
        {
            Money fiveFranc = Money.Franc(5);

            Assert.AreEqual(Money.Franc(10), fiveFranc.Times(2));
            Assert.AreEqual(Money.Franc(5), fiveFranc);
        }


        [TestMethod]
        public void Equals_CompareWithSameAmount_MustBeEqual()
        {
            Assert.AreEqual(Money.Franc(5), Money.Franc(5));
        }

        [TestMethod]
        public void Equals_CompareWithDifferentAmount_NotEqual()
        {
            Assert.AreNotEqual(Money.Franc(5), Money.Franc(6));
        }
    }
}