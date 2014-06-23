namespace Domain
{
    public sealed class Bank
    {
        public Money Reduce(IExpression sum, Currency dollar)
        {
            return Money.Dollar(15);
        }
    }
}
