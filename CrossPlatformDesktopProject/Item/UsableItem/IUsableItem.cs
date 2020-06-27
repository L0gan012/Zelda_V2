namespace Sprint2
{
    public interface IUsableItem : IItem
    {
<<<<<<< Updated upstream
        int DamageAmount { get; set; }
=======
        float DamageAmount { get; }
>>>>>>> Stashed changes

        void UseLeft();

        void UseRight();

        void UseDown();

        void UseUp();
    }
}
