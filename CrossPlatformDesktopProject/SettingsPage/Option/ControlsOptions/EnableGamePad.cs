
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sprint2
{
    public class EnableGamePad : AbstractOption
    {

        public static IController CurrentPad { get; private set; } = new GamePadController();

        public EnableGamePad(Vector2 position, Color color)
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

            Game1.Instance.Controllers.Add(CurrentPad);


        }

        public override void Draw(SpriteBatch sb, SpriteFont font)
        {
            sb.DrawString(font, "Enable GamePad", Position, Color);
        }

    }
}
