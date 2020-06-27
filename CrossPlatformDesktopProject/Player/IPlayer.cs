using Microsoft.Xna.Framework;

namespace Sprint2
{
    public interface IPlayer : IGameObject
    {
        float MaxHP { get; set; }

        float HP { get; set; }

        Enumerations.Sides FacingDirection { get; set; }

        void DamagePlayer(float damageAmount);

        void SetIdle();

        void Attack();

        void MoveLeft();

        void MoveRight();

        void MoveUp();

        void MoveDown();
    }
}
