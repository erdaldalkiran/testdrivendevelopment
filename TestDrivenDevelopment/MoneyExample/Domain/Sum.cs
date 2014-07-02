namespace Domain
{
    public class Sum : IExpression
    {
        public Sum(Money addend, Money augend)
        {
            Augend = augend;
            Addend = addend;
        }

        public Money Augend { get; private set; }
        public Money Addend { get; private set; }

        public Money Reduce(Currency currency)
        {
            var amount = Augend.Amount + Addend.Amount;
            return new Money(amount, currency);
        }
    }
}