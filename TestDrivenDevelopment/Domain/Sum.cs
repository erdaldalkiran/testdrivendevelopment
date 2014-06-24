namespace Domain
{
    public class Sum : IExpression
    {
        public Sum(Money augend, Money addend)
        {
            Augend = augend;
            Addend = addend;
        }
        public Money Augend { get; private set; }
        public Money Addend { get; private set; }

        public Money Reduce(Bank bank, Currency currency)
        {
            return new Money(Augend.Amount + Addend.Amount, currency);
        }
    }
}