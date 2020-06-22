﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteLinkIdleLeftGreen : AbstractSprite
    {
        public SpriteLinkIdleLeftGreen(Texture2D texture)
        {
                this.Texture = texture;
        }

        public override void Draw(SpriteBatch spriteBatch, Color color, Vector2 position)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            sourceRectangle = new Rectangle(96, 16, 16, 16);
            destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 16 * Constant.DisplayScaleX, 16 * Constant.DisplayScaleY);

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
