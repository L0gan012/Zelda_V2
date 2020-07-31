
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SetLoruleCastleALinkBetweenWorldsMusic : AbstractOption
    {
        public SetLoruleCastleALinkBetweenWorldsMusic(Vector2 position, Color color)
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

            SoundManager.Instance.PlayLoruleCastleALinkBetweenWorldsMusic();

        }

        public override void Draw(SpriteBatch sb, SpriteFont font)
        {
            sb.DrawString(font, "Lorule Castle A Link Between Worlds", Position, Color);

      
        }
    }
}
