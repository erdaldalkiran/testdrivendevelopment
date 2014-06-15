namespace Domain
{
    public class Franc : Money
    {
        public Franc(decimal amount, Currency currency)
            : base(amount, currency)
        {
        }
        public override Money Times(int multiplier)
        {
            return Money.Franc(this.Amount * multiplier);
        }
    }
}
