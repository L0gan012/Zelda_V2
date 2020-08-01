using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
namespace Sprint2
{
    public class ControlsPage : AbstractSettingsPage
    {
        public ControlsPage()
        {
            Title = StringConstants.Controls;

            Options.Add(new EnableGamePad(new Vector2(SettingsConstants.Option1Position.X * Constant.DisplayScaleX, SettingsConstants.Option1Position.Y * Constant.DisplayScaleY), Color.White));
            Options.Add(new DisableGamePad(new Vector2(SettingsConstants.Option2Position.X * Constant.DisplayScaleX, SettingsConstants.Option2Position.Y * Constant.DisplayScaleY), Color.White));
            Options.Add(new ChangeKey(new Vector2(SettingsConstants.Option3Position.X * Constant.DisplayScaleX, SettingsConstants.Option3Position.Y * Constant.DisplayScaleY), Color.White));


            background = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            background.SetData(new Color[] { Color.Black });
        }
    }
}
