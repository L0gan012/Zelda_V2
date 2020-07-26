using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class ScreenResolutionPage : AbstractSettingsPage
    {
        public ScreenResolutionPage()
        {
            Options.Add(new SetResolution1920x1080(Constant.ClassicDungeonOptionPosition, Color.White));
            Options.Add(new GoToPreferences(Constant.PreferencesOptionPosition, Color.White));

            background = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            background.SetData(new Color[] { Color.Black });
        }
    }
}
