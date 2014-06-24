namespace Domain
{
    public class Sum : IExpression
    {
        public Sum(IExpression augend, IExpression addend)
        {
            Augend = augend;
            Addend = addend;
        }
        public IExpression Augend { get; private set; }
        public IExpression Addend { get; private set; }

        public Money Reduce(Bank bank, Currency currency)
        {
            var amount = Augend.Reduce(bank, currency).Amount + Addend.Reduce(bank, currency).Amount;
            return new Money(amount, currency);
        }

        public IExpression Plus(IExpression addend)
        {
            return new Sum(this, addend);
        }

        public IExpression Times(int multiplier)
        {
            return new Sum(this.Augend.Times(multiplier), this.Addend.Times(multiplier));
        }
    }
}