using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class ScreenResolutionPage : AbstractSettingsPage
    {
        public ScreenResolutionPage()
        {
            Title = "Screen Resolution";

            Options.Add(new SetResolution1920x1080(Constant.Option1Position, Color.White));
            Options.Add(new SetResolution1366x768(Constant.Option2Position, Color.White));
            Options.Add(new SetResolution1440x900(Constant.Option3Position, Color.White));
            Options.Add(new SetResolution1536x864(Constant.Option4Position, Color.White));
            Options.Add(new SetResolutionDefault(Constant.Option5Position, Color.White));
            Options.Add(new SetResolutionFullScreen(Constant.Option6Position, Color.White));

            background = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            background.SetData(new Color[] { Color.Black });
        }
    }
}
