using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SetResolution1440x900 : AbstractOption
    {
        public SetResolution1440x900(Vector2 position, Color color)
        {
            Position = position;
            Color = color;
        }

        public override void Select()
        {
            if (Game1.Instance.State is StateSettings)
            {
                Game1.Instance.graphics.PreferredBackBufferWidth = 1440;
                Game1.Instance.graphics.PreferredBackBufferHeight = 900;
                Game1.Instance.graphics.ApplyChanges();
            }
        }


        public override void Draw(SpriteBatch spriteBatch, SpriteFont spriteFont)
        {
            spriteBatch.DrawString(spriteFont, "1440 x 900", Position, Color);
        }
    }
}
