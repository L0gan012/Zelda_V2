
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SetBOTWTheme : AbstractOption
    {
        public SetBOTWTheme(Vector2 position, Color color)
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

            SoundManager.Instance.PlayBOTWThemeMusic();

        }

        public override void Draw(SpriteBatch sb, SpriteFont font)
        {
            sb.DrawString(font, "BOTW Main Theme", Position, Color);

      
        }
    }
}
