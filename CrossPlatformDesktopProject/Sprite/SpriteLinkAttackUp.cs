using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteLinkAttackUp : AbstractAnimatedSprite
    {
        public SpriteLinkAttackUp(Texture2D texture)
        {
            Texture = texture;
            CurrentFrame = 0;
            TotalFrames = 4;
            CurrentTick = 0;
            TicksPerFrame = Constant.TicksPerFrameAttackSword;
        }

        public override void Draw(SpriteBatch spriteBatch, Color color, Vector2 position)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (CurrentFrame == 0)
            {
                sourceRectangle = new Rectangle(560, 16, 16, 16);
                destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);
            }
            else if (CurrentFrame == 1)
            {
                sourceRectangle = new Rectangle(576, 15, 16, 17);
                destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);
            }
            else if (CurrentFrame == 2)
            {
                sourceRectangle = new Rectangle(592, 16, 16, 16);
                destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);
            }
            else
            {
                sourceRectangle = new Rectangle(608, 16, 16, 16);
                destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);
            }

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, color);
            spriteBatch.End();
        }

        public override int GetHeight()
        {
            int height = Constant.LinkHeight * Constant.DisplayScaleY;
            return height;
        }

        public override int GetWidth()
        {
            int width = Constant.LinkWidth * Constant.DisplayScaleX;
            return width;
        }
    }
}
