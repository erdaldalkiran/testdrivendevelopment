using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Bank
    {
        private readonly Dictionary<Pair,decimal> _exchangeRates = new Dictionary<Pair, decimal>();

        public Money Reduce(IExpression source, Currency currency)
        {
            return source.Reduce(this,currency);
        }

        public void AddRate(Currency from, Currency to, decimal rate)
        {
            var pair = new Pair(from, to);
            if (!_exchangeRates.ContainsKey(pair))
            {
                _exchangeRates.Add(pair, rate);
            }
        }

        public decimal GetRate(Currency from, Currency to)
        {
            if (from == to)
            {
                return 1;
            }
            return _exchangeRates[new Pair(from, to)];
        }

        public class Pair
        {
            protected bool Equals(Pair other)
            {
                return _from == other._from && _to == other._to;
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    return ((int) _from*397) ^ (int) _to;
                }
            }

            private readonly Currency _from;
            private readonly Currency _to;

            public Pair(Currency from, Currency to)
            {
                _from = from;
                _to = to;
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

                return Equals(obj as Pair);
            }
        }
    }
}
