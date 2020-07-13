using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface ILinkState
    {
        ISprite Sprite { get; set; }

        void Update();

        void Draw(SpriteBatch spriteBatch, Color color);

        void DamageLink();

        void UseItem();

        void SetLinkIdle();

        void MoveLinkLeft();

        void MoveLinkRight();

        void MoveLinkUp();

        void MoveLinkDown();

        void Attack();

        void GetItem();
    }
}
