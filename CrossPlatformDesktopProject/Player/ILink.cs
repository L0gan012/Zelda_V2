using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface ILink
    {
        ILinkState State { get; set; }

        IItem Item { get; set; }

        Vector2 Position { get; set; }

        void Update();

        void Draw(SpriteBatch spriteBatch);

        void DamagePlayer();

        void UseItem();

        void SetIdle();

        void Attack();

        void MoveLeft();

        void MoveRight();

        void MoveUp();

        void MoveDown();
    }
}
