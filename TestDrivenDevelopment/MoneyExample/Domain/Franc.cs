namespace Domain
{
    public class Franc :Money
    {
        public Franc(decimal amount):base(amount)
        {
        }

        public override Money Times(int multiplier)
        {
            return new Franc(_amount * multiplier);
        }
    }
}