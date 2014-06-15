using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Test
{
    [TestClass]
    public class FrancTests
    {

        [TestMethod]
        public void Multiply_WithTwo_ANewFrancWithDoubledAmount()
        {
            var fiveFranc = Money.Franc(5);
            var tenFranc = fiveFranc.Times(2);
            Assert.AreEqual(10, tenFranc.Amount);
        }


        [TestMethod]
        public void Equal_AnotherFrancWithSameAmount_True()
        {
            Assert.AreEqual(Money.Franc(5), Money.Franc(5));
        }

        [TestMethod]
        public void Equal_AnotherFrancWithDifferentAmount_False()
        {
            Assert.AreNotEqual(Money.Franc(10), Money.Franc(13));
        }
     
        
    }
}
