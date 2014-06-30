namespace Domain
{
    public class Money
    {
        protected readonly decimal Amount;

        protected readonly Currency Currency;

        public Money(decimal amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }


        public override int GetHashCode()
        {
            return Amount.GetHashCode();
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

        public Money Times(int multiplier)
        {
            return new Money(Amount*multiplier, Currency);
        }
    }
}