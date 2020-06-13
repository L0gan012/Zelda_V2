using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2.Sprite
{
    class SpriteLinkAttackWoodenSwordUpGreen : ISprite
    {
        private Texture2D texture;
        private int currentFrame;
        private int totalFrames;
        private int currentTick;


        public SpriteLinkAttackWoodenSwordUpGreen(Texture2D texture)
        {
            this.texture = texture;
            currentFrame = 0;
            totalFrames = 4;
            currentTick = 0;
        }

        public void Update()
        {
            if (currentFrame < totalFrames)
            {
                if (currentTick >= Constant.TicksPerFrameAttackSword)
                {
                    currentTick = 0;
                    currentFrame++;
                }
                currentTick++;
            }

        }

        public void Draw(SpriteBatch spriteBatch, Color color, Vector2 position)
        {
            Vector2 weaponOffset = new Vector2(3, -12);


            Rectangle sourceRectangleAvatar;
            Rectangle destinationRectangleAvatar;
            Rectangle sourceRectangleWeapon;
            Rectangle destinationRectangleWeapon;




            if (currentFrame == 0)
            {
                   sourceRectangleAvatar = new Rectangle(576, 16, 16, 16);
                   destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                  sourceRectangleWeapon = new Rectangle(576 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 8, 12);
                  destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 8 * Constant.DisplayScaleX, 12 * Constant.DisplayScaleY);

            }

            else if (currentFrame == 1)
            {
                sourceRectangleAvatar = new Rectangle(576, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                weaponOffset = new Vector2(3, -12);
                sourceRectangleWeapon = new Rectangle(576 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 8, 12);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 8 * Constant.DisplayScaleX, 12 * Constant.DisplayScaleY);
            }
            else if (currentFrame == 2)
            {
                sourceRectangleAvatar = new Rectangle(592, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                weaponOffset = new Vector2(3, -11);
                sourceRectangleWeapon = new Rectangle(592 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 8, 11);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 8 * Constant.DisplayScaleX, 11 * Constant.DisplayScaleY);
            }
            else
            {
                sourceRectangleAvatar = new Rectangle(608, 16, 16, 16);
                destinationRectangleAvatar = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

                weaponOffset = new Vector2(3, -3);
                sourceRectangleWeapon = new Rectangle(608 + (int)weaponOffset.X, 16 + (int)weaponOffset.Y, 8, 3);
                destinationRectangleWeapon = new Rectangle((int)position.X + (int)weaponOffset.X * Constant.DisplayScaleX, (int)position.Y + (int)weaponOffset.Y * Constant.DisplayScaleY, 8 * Constant.DisplayScaleX, 3 * Constant.DisplayScaleY);

            }
            

            spriteBatch.Begin();
            spriteBatch.Draw(texture, destinationRectangleAvatar, sourceRectangleAvatar, color);
            spriteBatch.Draw(texture, destinationRectangleWeapon, sourceRectangleWeapon, color);
            spriteBatch.End();


        }
        public int GetHeight()
        {
            int height = Constant.LinkHeight * Constant.DisplayScaleY;
            return height;
        }

        public int GetWidth()
        {
            int width = Constant.LinkWidth * Constant.DisplayScaleX;
            return width;
        }
    }

}
