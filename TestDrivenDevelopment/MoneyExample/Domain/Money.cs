namespace Domain
{
    public abstract class Money
    {
        protected readonly decimal _amount;

        protected Money(decimal amount)
        {
            _amount = amount;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return obj is Money && this.GetType() == obj.GetType() && _amount == (obj as Money)._amount;
        }

        public static Dollar Dollar(decimal amount)
        {
            return new Dollar(amount);
        }

        public static Franc Franc(decimal amount)
        {
            return new Franc(amount);
        }

        public abstract Money Times(int multiplier);
    }
}