namespace Domain
{
    public class Money : IExpression
    {
        internal readonly decimal Amount;

        internal readonly Currency Currency;

        public Money(decimal amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }


        public override int GetHashCode()
        {
            return Amount.GetHashCode();
        }

        public Money Reduce(Bank bank, Currency to)
        {
            return new Money(Amount / bank.GetRate(Currency,to), to);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return obj is Money && Currency == (obj as Money).Currency && Amount == (obj as Money).Amount;
        }

        public static Money Dollar(decimal amount)
        {
            return new Money(amount, Currency.Dollar);
        }

        public static Money Franc(decimal amount)
        {
            return new Money(amount, Currency.Franc);
        }


        public override string ToString()
        {
            return string.Format("{0} {1}", Amount, Currency);
        }

        public IExpression Times(int multiplier)
        {
            return new Money(Amount * multiplier, Currency);
        }

        public IExpression Plus(IExpression addend)
        {
            return new Sum(this, addend);
        }
    }
}