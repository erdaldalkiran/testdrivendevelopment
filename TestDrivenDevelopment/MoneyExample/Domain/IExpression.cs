namespace Domain
{
    public interface IExpression
    {
        Money Reduce(Bank bank, Currency to);

        IExpression Times(int multiplier);

        IExpression Plus(IExpression addend);
    }
}
