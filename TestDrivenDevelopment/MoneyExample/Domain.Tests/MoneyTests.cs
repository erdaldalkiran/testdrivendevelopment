namespace Domain.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MoneyTests
    {

        [TestMethod]
        public void Multiplication_MultiplyWith2_DoubledAmount()
        {
            var fiveDollar = new Dollar(5);
            
            Assert.AreEqual(new Dollar(10), fiveDollar.Times(2));
            Assert.AreEqual(new Dollar(5), fiveDollar);
        }


        [TestMethod]
        public void Equals_CompareWithSameAmount_MustBeEqual()
        {
            Assert.AreEqual(new Dollar(5), new Dollar(5));
        }

        [TestMethod]
        public void Equals_CompareWithDifferentAmount_NotEqual()
        {
            Assert.AreNotEqual(new Dollar(5), new Dollar(6));
        }

    }
}