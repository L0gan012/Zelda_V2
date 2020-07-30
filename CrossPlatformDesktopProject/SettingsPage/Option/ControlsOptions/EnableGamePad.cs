
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
            CurrentPad.RegisterCommand();
            Game1.Instance.Controllers.Add(CurrentPad);
        }

        public override void Draw(SpriteBatch sb, SpriteFont font)
        {
            sb.DrawString(font, "Enable GamePad", Position, Color);
        }

    }
}
