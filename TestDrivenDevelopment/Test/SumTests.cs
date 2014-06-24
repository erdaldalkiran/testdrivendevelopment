using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class SumTests
    {
        
        [TestMethod]
        public void Plus_AddMoney_ExpectedBehavior()
        {
            var fiveBucks = Money.Dollar(5);
            var tenFranc = Money.Franc(10);
            var bank = new Bank();
            bank.AddRate(Currency.Franc, Currency.Dollar, 2);
            var sum = new Sum(fiveBucks, tenFranc).Plus(fiveBucks);
            var result = sum.Reduce(bank, Currency.Dollar);

            Assert.AreEqual(Money.Dollar(15), result);
        }

        
        [TestMethod]
        public void Sum_MultiplyWith3_ExpectedBehavior()
        {
            var fiveBucks = Money.Dollar(5);
            var tenFranc = Money.Franc(10);
            var bank = new Bank();
            bank.AddRate(Currency.Franc, Currency.Dollar, 2);
            var sum = new Sum(fiveBucks, tenFranc).Times(3);
            var result = sum.Reduce(bank, Currency.Dollar);

            Assert.AreEqual(Money.Dollar(30), result);
        }
        
        
    }
}
