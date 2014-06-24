namespace Domain
{
    public interface IExpression
    {
        Money Reduce(Bank bank, Currency currency);
    }
}