using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class GameSelectionPage : AbstractSettingsPage
    {
        public GameSelectionPage()
        {
            Options.Add(new FirstDungeon(new Vector2(SettingsConstants.Option1Position.X * Constant.DisplayScaleX, SettingsConstants.Option1Position.Y * Constant.DisplayScaleY), Color.White));
            Options.Add(new SecondDungeon(new Vector2(SettingsConstants.Option2Position.X * Constant.DisplayScaleX, SettingsConstants.Option2Position.Y * Constant.DisplayScaleY), Color.White));
            Options.Add(new GoToPreferences(new Vector2(SettingsConstants.Option2Position.X * Constant.DisplayScaleX, SettingsConstants.Option2Position.Y * Constant.DisplayScaleY), Color.White));

            background = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            background.SetData(new Color[] { Color.Black });
        }
    }
}
