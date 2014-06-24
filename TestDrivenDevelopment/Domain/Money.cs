using System;
namespace Domain
{
    public class Money : IExpression
    {
        public Money(decimal amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public decimal Amount { get; private set; }

        public Currency Currency { get; private set; }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType()) return false;

            var other = (Money)obj;

            return this.Amount == other.Amount && this.Currency == other.Currency;
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(Math.Floor(Amount));
        }

        public Money Reduce(Bank bank, Currency currency)
        {
            var rate = bank.Rate(this.Currency, currency);
            return new Money(this.Amount / rate, currency);
        }

        public static Money Dollar(decimal amount)
        {
            return new Money(amount, Currency.Dollar);
        }

        public static Money Franc(decimal amount)
        {
            return new Money(amount, Currency.Franc);
        }

        public Money Times(int multiplier)
        {
            return new Money(this.Amount * multiplier, this.Currency);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.Amount, this.Currency);
        }

        public IExpression Plus(Money addend)
        {
            return new Sum(this, addend);
        }
    }
}
