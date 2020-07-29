
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sprint2
{
    public class DisbaleGamePad : AbstractOption
    {

        public DisbaleGamePad(Vector2 position, Color color)
        {
            Position = position;
            Color = color;
        }

        public override void Select()
        {
            base.Select();
            if (Game1.Instance.State is StateSettings)
            {
                ((StateSettings)Game1.Instance.State).SettingsPage = new ControlsPage();
            }

            if (Game1.Instance.Controllers.Contains(EnableGamePad.CurrentPad)) {
                Game1.Instance.Controllers.Remove(EnableGamePad.CurrentPad);
            }


        }

        public override void Draw(SpriteBatch sb, SpriteFont font)
        {
            sb.DrawString(font, "Disbale GamePad", Position, Color);
        }


            


    }
}
