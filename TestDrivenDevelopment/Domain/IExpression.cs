namespace Domain
{
    public interface IExpression
    {
        Money Reduce(Bank bank, Currency currency);
        IExpression Plus(IExpression addend);
        IExpression Times(int multiplier);
    }
}