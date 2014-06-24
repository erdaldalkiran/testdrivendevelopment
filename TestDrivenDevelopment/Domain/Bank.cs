namespace Domain
{
    using System;
    using System.Collections;

    public sealed class Bank
    {
        private Hashtable Rates = new Hashtable();
        public Money Reduce(IExpression source, Currency currency)
        {
            return source.Reduce(this, currency);
        }

        public decimal Rate(Currency from, Currency to)
        {
            if (from == to) return 1;
            return Convert.ToDecimal(Rates[new Pair(from, to)]);
        }

        public void AddRate(Currency from, Currency to, decimal rate)
        {
            Rates.Add(new Pair(from, to), rate);
        }

        private sealed class Pair
        {
            private bool Equals(Pair other)
            {
                return this.From == other.From && this.To == other.To;
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    return ((int)this.From * 397) ^ (int)this.To;
                }
            }

            internal Pair(Currency from, Currency to)
            {
                From = from;
                To = to;
            }
            private Currency From { get; set; }

            private Currency To { get; set; }

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
                return obj is Pair && Equals((Pair)obj);
            }
        }
    }
}
