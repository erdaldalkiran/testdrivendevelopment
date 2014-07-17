namespace Domain
{
    public class Sum : IExpression
    {
        public Sum( IExpression augend,IExpression addend)
        {
            Augend = augend;
            Addend = addend;
        }

        public IExpression Augend { get; private set; }
        public IExpression Addend { get; private set; }

        public Money Reduce(Bank bank, Currency to)
        {
            var amount = Augend.Reduce(bank, to).Amount + Addend.Reduce(bank, to).Amount;
            return new Money(amount, to);
        }

        public IExpression Times(int multiplier)
        {
            return new Sum(Augend.Times(multiplier), Addend.Times(multiplier));
        }

        public IExpression Plus(IExpression addend)
        {
            return new Sum(this, addend);
        }
    }
}