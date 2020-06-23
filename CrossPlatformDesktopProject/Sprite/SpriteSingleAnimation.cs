﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteSingleAnimation : ISprite
    {
        public Texture2D Texture { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
        private int currentFrame;
        private int totalFrames;
        private int ticksPerFrame;

        public SpriteSingleAnimation(Texture2D texture, int row, int column, int ticksPerFrame)
        {
            Texture = texture;
            Rows = row;
            Columns = column;
            currentFrame = 0;
            totalFrames = Rows * Columns;
            this.ticksPerFrame = ticksPerFrame;
        }

        public void Draw(SpriteBatch spriteBatch, Color color, Vector2 position)
        {
            int width = Texture.Width / Columns;
            int height = Texture.Height / Rows;
            int row = (int)((float)currentFrame / (float)Columns);
            int column = currentFrame % Columns;

            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, width * Constant.DisplayScaleX, height * Constant.DisplayScaleY);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, color);
            spriteBatch.End();
        }

        public void Update()
        {
            //No need for Update with only a single image
        }

        public int GetHeight()
        {
            int height = Texture.Height * Constant.DisplayScaleY / Rows;
            return height;
        }

        public int GetWidth()
        {
            int width = Texture.Width * Constant.DisplayScaleX / Rows;
            return width;
        }

        public void Draw(SpriteBatch spriteBatch, Color color, Rectangle position)
        {

        }
    }
}
