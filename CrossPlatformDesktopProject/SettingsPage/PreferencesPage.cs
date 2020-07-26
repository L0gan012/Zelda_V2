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

            Options.Add(new GoToMusicSelection(Constant.Option1Position, Color.White));
            Options.Add(new GoToControls(Constant.Option2Position, Color.White));
            Options.Add(new GoToScreenResolution(Constant.Option3Position, Color.White));

            background = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            background.SetData(new Color[] { Color.Black });
        }
    }
}
