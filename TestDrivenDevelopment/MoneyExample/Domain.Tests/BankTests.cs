using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.Tests
{
    [TestClass]
    public class BankTests
    {
        
        [TestMethod]
        public void Reduce_5DollarsPassed_5Dollars()
        {
            var bank = new Bank();
            var reduce = bank.Reduce(Money.Dollar(5), Currency.Dollar);

            Assert.AreEqual(Money.Dollar(5),reduce);
        }

        
        [TestMethod]
        public void Reduce_Franc_ToDollar()
        {
            var bank = new Bank();
            bank.AddRate(Currency.Franc, Currency.Dollar,2);
            var franc = Money.Franc(2);

            var result = bank.Reduce(franc, Currency.Dollar);

            Assert.AreEqual(Money.Dollar(1),result);
        }
        
    }
}
