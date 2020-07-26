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

            Options.Add(new GoToMusicSelection(Constant.MusicOptionPosition, Color.White));
            Options.Add(new GoToControls(Constant.ControlsOptionPosition, Color.White));
            Options.Add(new GoToScreenResolution(Constant.ResolutionOptionPosition, Color.White));

            background = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            background.SetData(new Color[] { Color.Black });
        }
    }
}
