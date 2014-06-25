namespace Domain
{
    public class Dollar
    {
        protected bool Equals(Dollar other)
        {
            return this._amount == other._amount;
        }

        public override int GetHashCode()
        {
            return this._amount.GetHashCode();
        }

        public Dollar(decimal amount)
        {
            this._amount = amount;
        }

        private decimal _amount { get; set; }

        public Dollar Times(int multiplier)
        {
            return new Dollar(_amount * multiplier);
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
            
            return obj is Dollar && _amount == (obj as Dollar)._amount;
        }
    }
}