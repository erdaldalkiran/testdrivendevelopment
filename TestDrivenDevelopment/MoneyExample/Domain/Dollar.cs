namespace Domain
{
    public class Dollar :Money
    {
        public Dollar(decimal amount):base(amount)
        {
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(_amount * multiplier);
        }
    }
}