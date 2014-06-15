namespace Domain
{
    public class Dollar : Money
    {
        public Dollar(decimal amount,Currency currency)
            : base(amount,currency)
        {
        }

        public override Money Times(int multiplier)
        {
            return Money.Dollar(this.Amount * multiplier);
        }
    }
}
