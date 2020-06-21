using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2.Sprite
{
    public class SpriteLinkAttackWoodenSwordDownGreen : AbstractAnimatedSprite
    {
        public SpriteLinkAttackWoodenSwordDownGreen(Texture2D texture)
        {

            this.Texture = texture;
            CurrentFrame = 0;
            TotalFrames = 3;
            CurrentTick = 0;
        }

        public override void Update()
        {
            if (CurrentFrame < TotalFrames)
            {
                if (CurrentTick >= Constant.TicksPerFrameAttackSword)
                {
                    CurrentTick = 0;
                    CurrentFrame++;
                }
                CurrentTick++;
            }

        }

        public override void Draw(SpriteBatch spriteBatch, Color color, Vector2 position)
        {
            Vector2 weaponOffset = new Vector2(5, 16);

            Rectangle sourceRectangleAvatar;
            Rectangle destinationRectangleAvatar;
            Rectangle sourceRectangleWeapon;
            Rectangle destinationRectangleWeapon;

            if (CurrentFrame == 0)
            {
                sourceRectangleAvatar = new Rectangle(208, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                sourceRectangleWeapon = new Rectangle(208 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 8, 11);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 8 * Constant.DisplayScaleX, 11 * Constant.DisplayScaleY);
            }
             if (CurrentFrame == 1)
            {
                sourceRectangleAvatar = new Rectangle(208, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                sourceRectangleWeapon = new Rectangle(208 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 8, 11);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 8 * Constant.DisplayScaleX, 11 * Constant.DisplayScaleY);
            }
            else if (CurrentFrame == 2)
            {
                sourceRectangleAvatar = new Rectangle(224, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                sourceRectangleWeapon = new Rectangle(224 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 8, 7);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 8 * Constant.DisplayScaleX, 7 * Constant.DisplayScaleY);
            }
            else
            {
                sourceRectangleAvatar = new Rectangle(240, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                sourceRectangleWeapon = new Rectangle(224 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 8, 3);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 8 * Constant.DisplayScaleX, 3 * Constant.DisplayScaleY);
            }

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangleAvatar, sourceRectangleAvatar, color);
            spriteBatch.Draw(Texture, destinationRectangleWeapon, sourceRectangleWeapon, color);
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
