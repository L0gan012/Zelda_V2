using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class GameSelectionPage : AbstractSettingsPage
    {
        public GameSelectionPage()
        {
            Options.Add(new GoToClassicGame(Constant.ClassicDungeonOptionPosition, Color.White));
            Options.Add(new GoToPreferences(Constant.PreferencesOptionPosition, Color.White));

            background = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            background.SetData(new Color[] { Color.Black });
        }
    }
}
