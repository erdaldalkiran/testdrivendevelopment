namespace Domain
{
    public interface IExpression
    {
        Money Reduce(Currency currency);
    }
}
