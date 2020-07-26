﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Sprint2
{
    public class SetResolution1366x768 : AbstractOption
    {
        public SetResolution1366x768(Vector2 position, Color color)
        {
            Position = position;
            Color = color;
        }

        public override void Select()
        {
            if (Game1.Instance.State is StateSettings)
            {
                Game1.Instance.graphics.PreferredBackBufferWidth = 1366;
                Game1.Instance.graphics.PreferredBackBufferHeight = 768;
                Game1.Instance.graphics.ApplyChanges();

                Constant.DisplayScaleX = Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth;
                Constant.DisplayScaleY = Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight;

                Console.WriteLine($"Display Scale X: {Constant.DisplayScaleX}\nDisplay Scale Y: {Constant.DisplayScaleY}");
            }
        }


        public override void Draw(SpriteBatch spriteBatch, SpriteFont spriteFont)
        {
            spriteBatch.DrawString(spriteFont, "1366 x 768", Position, Color);
        }
    }
}
