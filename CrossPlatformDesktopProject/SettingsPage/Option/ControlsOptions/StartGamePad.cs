
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sprint2
{
    public class StartGamePad : AbstractOption
    {
        private GamePadState checkConnection;
        public StartGamePad(Vector2 position, Color color)
        {
            Position = position;
            Color = color;
            checkConnection = new GamePadState();
        }

        public override void Select()
        {
            base.Select();
            if (Game1.Instance.State is StateSettings)
            {
                ((StateSettings)Game1.Instance.State).SettingsPage = new ControlsPage();
            }


                Game1.Instance.Controllers.Add(new GamePadController());


          

        }

        public override void Draw(SpriteBatch sb, SpriteFont font)
        {
            sb.DrawString(font, "Start Game Pad", Position, Color);

      
        }
    }
}
