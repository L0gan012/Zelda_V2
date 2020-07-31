using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class PreferencesPage : AbstractSettingsPage
    {
        public PreferencesPage()
        {
            Title = "Preferences";

            Options.Add(new GoToMusicSelection(new Vector2(SettingsConstants.Option1Position.X * Constant.DisplayScaleX, SettingsConstants.Option1Position.Y * Constant.DisplayScaleY), Color.White));
            Options.Add(new GoToControls(new Vector2(SettingsConstants.Option2Position.X * Constant.DisplayScaleX, SettingsConstants.Option2Position.Y * Constant.DisplayScaleY), Color.White));
            Options.Add(new GoToScreenResolution(new Vector2(SettingsConstants.Option3Position.X * Constant.DisplayScaleX, SettingsConstants.Option3Position.Y * Constant.DisplayScaleY), Color.White));
            Options.Add(new GoToInstructions(new Vector2(SettingsConstants.Option4Position.X * Constant.DisplayScaleX, SettingsConstants.Option4Position.Y * Constant.DisplayScaleY), Color.White));

            background = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            background.SetData(new Color[] { Color.Black });
        }
    }
}
