using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.Tests
{
    [TestClass]
    public class SumTests
    {

        [TestMethod]
        public void SumPlusMoney()
        {
            IExpression fiveBucks = Money.Dollar(5);
            IExpression tenFrancs = Money.Franc(10);
            var bank = new Bank();
            bank.AddRate(Currency.Franc, Currency.Dollar, 2);

            var sum = new Sum(fiveBucks, tenFrancs).Plus(fiveBucks);
            var reduced = bank.Reduce(sum, Currency.Dollar);

            Assert.AreEqual(Money.Dollar(15), reduced);
        }

        
        [TestMethod]
        public void Times()
        {
            IExpression fiveBucks = Money.Dollar(5);
            IExpression tenFrancs = Money.Franc(10);
            var bank = new Bank();
            bank.AddRate(Currency.Franc, Currency.Dollar, 2);

            var sum = new Sum(fiveBucks, tenFrancs).Times(4);
            var reduced = bank.Reduce(sum, Currency.Dollar);

            Assert.AreEqual(Money.Dollar(40), reduced);
        }
        

    }
}