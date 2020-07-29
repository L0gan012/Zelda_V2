using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
namespace Sprint2
{
    public class ControlsPage : AbstractSettingsPage
    {
        public ControlsPage()
        {
            Title = "Controls Page";

            Options.Add(new GamePad(new Vector2(SettingsConstants.Option1Position.X * Constant.DisplayScaleX, SettingsConstants.Option1Position.Y * Constant.DisplayScaleY), Color.White));

            background = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            background.SetData(new Color[] { Color.Black });
        }
    }
}
