using System;
namespace Domain
{
    public abstract class Money
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
            if (obj == null || obj.GetType() != this.GetType()) return false;

            var other = (Money)obj;

            return this.Amount == other.Amount;
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(Math.Floor(Amount));
        }

        public static Money Dollar(decimal amount)
        {
            return new Dollar(amount, Currency.Dollar);
        }

        public static Money Franc(decimal amount)
        {
            return new Franc(amount, Currency.Franc);
        }

        public abstract Money Times(int multiplier);
    }
}
