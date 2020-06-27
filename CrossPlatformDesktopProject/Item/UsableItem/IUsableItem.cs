namespace Sprint2
{
    public interface IUsableItem : IItem
    {
        public int DamageAmount { get; set; }

        void UseLeft();

        void UseRight();

        void UseDown();

        void UseUp();
    }
}
