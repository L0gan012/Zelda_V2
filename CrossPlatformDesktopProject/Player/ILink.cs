using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface ILink
    {
        Color Color { get; set; }

        Vector2 Position { get; set; }

        ILinkState State { get; set; }

        IUsableItem PrimaryItem { get; set; }

        IUsableItem SecondaryItem { get; set; }

        Vector2 Center { get; }

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
