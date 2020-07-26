using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class GameSelectionPage : AbstractSettingsPage
    {
        public GameSelectionPage()
        {
            Options.Add(new GoToClassicGame(Constant.Option1Position, Color.White));
            Options.Add(new GoToPreferences(Constant.Option2Position, Color.White));

            background = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            background.SetData(new Color[] { Color.Black });
        }
    }
}
