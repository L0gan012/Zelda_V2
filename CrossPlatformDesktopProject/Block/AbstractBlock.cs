﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Sprint2
{
    class AbstractBlock : AbstractGameObject, IBlock
    {
        //location of this should possibly change
        public override Enumerations.GameObjectType GameObjectType
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public bool IsMovable { get; set; }
    }

    /*
    class Blocks : IBlock
    {
        private int currentFrame;
        private int totalFrames;

        public Texture2D Texture { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }

        public Blocks(Texture2D texture, int row, int column)
        {
            Texture = texture;
            Rows = row;
            Columns = column;
            currentFrame = 0;
            totalFrames = Rows * Columns;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            int width = Texture.Width / Columns;
            int height = Texture.Height / Rows;
            int row = (int)((float)currentFrame / (float)Columns);
            int column = currentFrame % Columns;

            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width * Constant.DisplayScaleX, height * Constant.DisplayScaleY);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;
        }
    }
    */
}
