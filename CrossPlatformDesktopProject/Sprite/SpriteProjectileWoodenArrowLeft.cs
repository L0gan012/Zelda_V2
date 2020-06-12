﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2.Sprite
{
    public class SpriteProjectileWoodenArrowLeft : ISprite
    {
        private Texture2D texture;
        private int rows;
        private int columns;
        private int currentFrame;
        private int totalFrames;



        public SpriteProjectileWoodenArrowLeft(Texture2D texture)
        {
            this.texture = texture;
            rows = 1;
            columns = 1;
            currentFrame = 0;
            totalFrames = rows * columns;
        }


        public void Update()
        {

        }


        public void Draw(SpriteBatch spriteBatch, Color color,  Vector2 position)
        {
            int width = this.texture.Width / columns;
            int height = this.texture.Height / rows;
            int row = (int)((float)currentFrame / (float)columns);
            int column = currentFrame % columns;

            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, width * Constant.DisplayScaleX, height * Constant.DisplayScaleY);

            spriteBatch.Begin();
            spriteBatch.Draw(this.texture, destinationRectangle, sourceRectangle, color);
            spriteBatch.End();
        }
        public int GetHeight()
        {
            int height = this.texture.Height * Constant.DisplayScaleY / rows;
            return height;
        }

        public int GetWidth()
        {
            int width = this.texture.Width * Constant.DisplayScaleX / rows;
            return width;
        }
    }
}
