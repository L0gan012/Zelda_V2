
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SetHyruleFieldOOTMusic : AbstractOption
    {
        public SetHyruleFieldOOTMusic(Vector2 position, Color color)
        {
            Position = position;
            Color = color;
        }

        public override void Select()
        {
            if (Game1.Instance.State is StateSettings)
            {
                ((StateSettings)Game1.Instance.State).SettingsPage = new MusicSelectionPage();
            }

            SoundManager.Instance.PlayHyruleFieldOOTMusic();

        }

        public override void Draw(SpriteBatch sb, SpriteFont font)
        {
            sb.DrawString(font, "Hyrule Field", Position, Color);

      
        }
    }
}
