using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class ScreenResolutionPage : AbstractSettingsPage
    {
        public ScreenResolutionPage()
        {
            Title = "Screen Resolution";

            Options.Add(new SetResolution1920x1080(new Vector2(SettingsConstants.Option1Position.X * Constant.DisplayScaleX, SettingsConstants.Option1Position.Y * Constant.DisplayScaleY), Color.White));
            Options.Add(new SetResolution1366x768(new Vector2(SettingsConstants.Option2Position.X * Constant.DisplayScaleX, SettingsConstants.Option2Position.Y * Constant.DisplayScaleY), Color.White));
            Options.Add(new SetResolution1440x900(new Vector2(SettingsConstants.Option3Position.X * Constant.DisplayScaleX, SettingsConstants.Option3Position.Y * Constant.DisplayScaleY), Color.White));
            Options.Add(new SetResolution1536x864(new Vector2(SettingsConstants.Option4Position.X * Constant.DisplayScaleX, SettingsConstants.Option4Position.Y * Constant.DisplayScaleY), Color.White));
            Options.Add(new SetResolutionDefault(new Vector2(SettingsConstants.Option5Position.X * Constant.DisplayScaleX, SettingsConstants.Option5Position.Y * Constant.DisplayScaleY), Color.White));
            Options.Add(new SetResolutionFullScreen(new Vector2(SettingsConstants.Option6Position.X * Constant.DisplayScaleX, SettingsConstants.Option6Position.Y * Constant.DisplayScaleY), Color.White));

            background = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            background.SetData(new Color[] { Color.Black });
        }
    }
}
