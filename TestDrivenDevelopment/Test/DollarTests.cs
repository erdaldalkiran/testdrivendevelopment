namespace Test
{
    using Domain;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    [TestClass]
    public class DollarTests
    {
        [TestMethod]
        public void Multiply_WithTwo_ANewDollarWithDoubledAmount()
        {
            var fiveDollar =Money.Dollar(5);
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
        public void Equal_FrancWithSameAmount_False()
        {
            Assert.AreNotEqual(Money.Dollar(10), Money.Franc(10));
        }
        
        
    }
}
