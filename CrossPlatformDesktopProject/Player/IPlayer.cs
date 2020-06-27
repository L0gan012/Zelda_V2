namespace Sprint2
{
    public interface IPlayer : IGameObject
    {
        Enumerations.Sides FacingDirection { get; set; }

        void DamagePlayer();

        void SetIdle();

        void Attack();

        void MoveLeft();

        void MoveRight();

        void MoveUp();

        void MoveDown();
    }
}
