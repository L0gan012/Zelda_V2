using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteLinkAttackWoodenSwordLeftGreen : AbstractAnimatedSprite
    {
        public SpriteLinkAttackWoodenSwordLeftGreen(Texture2D texture)
        {
            Texture = texture;
            CurrentFrame = 0;
            TotalFrames = 4;
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
            Vector2 weaponOffset = new Vector2(-11, 5);

            Rectangle sourceRectangleAvatar;
            Rectangle destinationRectangleAvatar;
            Rectangle sourceRectangleWeapon;
            Rectangle destinationRectangleWeapon;

            if (CurrentFrame == 0)
            {
                sourceRectangleAvatar = new Rectangle(464, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                sourceRectangleWeapon = new Rectangle(464 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 11, 8);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 11 * Constant.DisplayScaleX, 8 * Constant.DisplayScaleY);
            }
            else if (CurrentFrame == 1)
            {
                weaponOffset = new Vector2(-11, 5);
                sourceRectangleAvatar = new Rectangle(464, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                sourceRectangleWeapon = new Rectangle(464 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 11, 8);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 11 * Constant.DisplayScaleX, 8 * Constant.DisplayScaleY);
            }
            else if (CurrentFrame == 2)
            {
                sourceRectangleAvatar = new Rectangle(496, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                weaponOffset = new Vector2(-7, 5);
                sourceRectangleWeapon = new Rectangle(496 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 7, 8);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 7 * Constant.DisplayScaleX, 8 * Constant.DisplayScaleY);
            }
            else
            {
                sourceRectangleAvatar = new Rectangle(528, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                weaponOffset = new Vector2(-3, 5);
                sourceRectangleWeapon = new Rectangle(528 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 3, 8);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 3 * Constant.DisplayScaleX, 8 * Constant.DisplayScaleY);
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

