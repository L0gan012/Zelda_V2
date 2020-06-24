using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace Sprint2
{
    public interface IPlayer : IGameObject
    {
        void DamagePlayer();

        void SetIdle();

        void Attack();

        void MoveLeft();

        void MoveRight();

        void MoveUp();

        void MoveDown();
    }
}
