using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SetResolutionFullScreen : AbstractOption
    {
        public SetResolutionFullScreen(Vector2 position, Color color)
        {
            Position = position;
            Color = color;
        }

        public override void Select()
        {
            if (Game1.Instance.State is StateSettings)
            {
                if (Game1.Instance.graphics.IsFullScreen)
                {
                    Game1.Instance.graphics.IsFullScreen = false;
                }
                else
                {
                    Game1.Instance.graphics.IsFullScreen = true;
                }
                Game1.Instance.graphics.ApplyChanges();
            }
        }


        public override void Draw(SpriteBatch spriteBatch, SpriteFont spriteFont)
        {
            spriteBatch.DrawString(spriteFont, StringConstants.FullScreen, Position, Color);
        }
    }
}
