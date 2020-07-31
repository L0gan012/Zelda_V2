
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SetZeddLegendOfZeldaHD : AbstractOption
    {
        public SetZeddLegendOfZeldaHD(Vector2 position, Color color)
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

            SoundManager.Instance.PlayZeddLegendOfZeldaHDMusic();

        }

        public override void Draw(SpriteBatch sb, SpriteFont font)
        {
            sb.DrawString(font, "Zedd Legend Of Zelda HD Remix", Position, Color);

      
        }
    }
}
