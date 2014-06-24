namespace Domain
{
    using System;
    using System.Collections;

    public sealed class Bank
    {
        #region Fields

        private readonly Hashtable Rates = new Hashtable();

        #endregion

        #region Public Methods and Operators

        public void AddRate(Currency from, Currency to, decimal rate)
        {
            Rates.Add(new Pair(from, to), rate);
        }

        public decimal Rate(Currency from, Currency to)
        {
            if (from == to)
            {
                return 1;
            }
            return Convert.ToDecimal(Rates[new Pair(from, to)]);
        }

        public Money Reduce(IExpression source, Currency currency)
        {
            return source.Reduce(this, currency);
        }

        #endregion

        private sealed class Pair
        {
            #region Constructors and Destructors

            internal Pair(Currency from, Currency to)
            {
                From = from;
                To = to;
            }

            #endregion

            #region Properties

            private Currency From { get; set; }

            private Currency To { get; set; }

            #endregion

            #region Public Methods and Operators

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

            public override int GetHashCode()
            {
                unchecked
                {
                    return ((int)this.From * 397) ^ (int)this.To;
                }
            }

            #endregion

            #region Methods

            private bool Equals(Pair other)
            {
                return this.From == other.From && this.To == other.To;
            }

            #endregion
        }
    }
}