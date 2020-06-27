namespace Sprint2
{
    public interface IUsableItem : IItem
    {
        float DamageAmount { get; }

        void UseLeft();

        void UseRight();

        void UseDown();

        void UseUp();
    }
}
