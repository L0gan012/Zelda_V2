﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2.Sprite
{
    public class SpriteProjectileWoodenSwordDown : ISprite
    {
        private Texture2D texture;
        private int rows;
        private int columns;
        private int currentTick;
        private int currentFrame;
        private int totalFrames;
        private int ticksPerFrame;



        public SpriteProjectileWoodenSwordDown(Texture2D texture)
        {
            this.texture = texture;
            rows = 1;
            columns = 4;
            currentFrame = 0;
            currentTick = 0;
            totalFrames = rows * columns;
            ticksPerFrame = Constant.TicksPerFrameSwordProjectiles;
        }


        public void Update()
        {
            if (currentTick >= ticksPerFrame)
            {
                currentTick = 0;
                currentFrame++;
                if (currentFrame >= totalFrames)
                    currentFrame = 0;
            }
            currentTick++;
        }


        public void Draw(SpriteBatch spriteBatch, Color color, Vector2 position)
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
