
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sprint2
{
    public class DisableGamePad : AbstractOption
    {
        public DisableGamePad(Vector2 position, Color color)
        {
            Position = position;
            Color = color;
        }

        public override void Select()
        {
            if (Game1.Instance.Controllers.Contains(EnableGamePad.CurrentPad)) {
                EnableGamePad.CurrentPad.DeregisterCommands();
                Game1.Instance.Controllers.Remove(EnableGamePad.CurrentPad);
            }
        }

        public override void Draw(SpriteBatch sb, SpriteFont font)
        {
            sb.DrawString(font, StringConstants.DisableGamePad, Position, Color);
        }

    }
}
