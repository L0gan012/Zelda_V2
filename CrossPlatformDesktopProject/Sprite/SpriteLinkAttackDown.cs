using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteLinkAttackDown : AbstractAnimatedSprite
    {
        public SpriteLinkAttackDown(Texture2D texture)
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
                sourceRectangle = new Rectangle(192, 16, 16, 16);
                destinationRectangle = new Rectangle((int)position.X, (int)position.Y, (int)(16 * Constant.DisplayScaleX), (int)(16 * Constant.DisplayScaleY));
            }
            else if (CurrentFrame == 1)
            {
                sourceRectangle = new Rectangle(208, 16, 16, 16);
                destinationRectangle = new Rectangle((int)position.X, (int)position.Y, (int)(16 * Constant.DisplayScaleX), (int)(16 * Constant.DisplayScaleY));
            }
            else if (CurrentFrame == 2)
            {
                sourceRectangle = new Rectangle(224, 16, 16, 16);
                destinationRectangle = new Rectangle((int)position.X, (int)position.Y, (int)(16 * Constant.DisplayScaleX), (int)(16 * Constant.DisplayScaleY));
            }
            else
            {
                sourceRectangle = new Rectangle(240, 16, 16, 16);
                destinationRectangle = new Rectangle((int)position.X, (int)position.Y, (int)(16 * Constant.DisplayScaleX), (int)(16 * Constant.DisplayScaleY));
            }

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
