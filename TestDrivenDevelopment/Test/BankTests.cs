namespace Test
{
    using Domain;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BankTests
    {

        [TestMethod]
        public void Reduce_Sum3DollarsAnd4Dollars_7Dollars()
        {
            var sum = new Sum(Money.Dollar(3), Money.Dollar(4));
            var result = new Bank().Reduce(sum, Currency.Dollar);

            Assert.AreEqual(Money.Dollar(7), result);
        }


        [TestMethod]
        public void Reduce_Money_Money()
        {
            var result = new Bank().Reduce(Money.Dollar(2), Currency.Dollar);

            Assert.AreEqual(Money.Dollar(2), result);
        }


        [TestMethod]
        public void Reduce_MoneyInDollars_ToFranc()
        {
            var bank = new Bank();
            bank.AddRate(Currency.Franc, Currency.Dollar, 2);
            var result = bank.Reduce(Money.Franc(2), Currency.Dollar);

            Assert.AreEqual(Money.Dollar(1), result);
        }


        [TestMethod]
        public void Rate_SameCurrencies_1()
        {
            var rate = new Bank().Rate(Currency.Dollar, Currency.Dollar);

            Assert.AreEqual(1, rate);
        }


        [TestMethod]
        public void Reduce_MixedAddition_ReducedCurrency()
        {
            IExpression fiveBucks = Money.Dollar(5);
            IExpression tenFranc = Money.Franc(10);
            var bank = new Bank();
            bank.AddRate(Currency.Franc, Currency.Dollar, 2);
            
            var result = bank.Reduce(fiveBucks.Plus(tenFranc), Currency.Dollar);

            Assert.AreEqual(Money.Dollar(10),result);
        }
    }
}