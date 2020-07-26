using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteLinkIdleRight : AbstractSprite
    {
        public SpriteLinkIdleRight(Texture2D texture)
        {
            Texture = texture;
        }

        public override void Draw(SpriteBatch spriteBatch, Color color, Vector2 position)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            sourceRectangle = new Rectangle(48, 16, 16, 16);
            destinationRectangle = new Rectangle((int)position.X, (int)position.Y, (int)(16 * Constant.DisplayScaleX), (int)(16 * Constant.DisplayScaleY));

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, color);
        }

        public override float GetHeight()
        {
            float height = Constant.LinkHeight * Constant.DisplayScaleY;
            return height;
        }

        public override float GetWidth()
        {
            float width = Constant.LinkWidth * Constant.DisplayScaleX;
            return width;
        }
    }
}