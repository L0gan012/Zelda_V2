using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Sprint2
{
    public class SetResolution1536x864 : AbstractOption
    {
        public SetResolution1536x864(Vector2 position, Color color)
        {
            Position = position;
            Color = color;
        }

        public override void Select()
        {
            if (Game1.Instance.State is StateSettings)
            {
                Game1.Instance.graphics.PreferredBackBufferWidth = 1536;
                Game1.Instance.graphics.PreferredBackBufferHeight = 864;
                Game1.Instance.graphics.ApplyChanges();

                Constant.DisplayScaleX = Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth;
                Constant.DisplayScaleY = Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight;

                Console.WriteLine($"Display Scale X: {Constant.DisplayScaleX}\nDisplay Scale Y: {Constant.DisplayScaleY}");
            }
        }


        public override void Draw(SpriteBatch spriteBatch, SpriteFont spriteFont)
        {
            spriteBatch.DrawString(spriteFont, "1536 x 864", Position, Color);
        }
    }
}
