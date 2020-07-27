using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
namespace Sprint2
{
    public class MusicSelectionPage : AbstractSettingsPage
    {

        public MusicSelectionPage()
        {

            Title = "Music Settings";

            //add options
            Options.Add(new SetGerudoValley(new Vector2(SettingsConstants.Option1Position.X * Constant.DisplayScaleX, SettingsConstants.Option1Position.Y * Constant.DisplayScaleY), Color.White));
            Options.Add(new SetLostWoodsOOT(new Vector2(SettingsConstants.Option2Position.X * Constant.DisplayScaleX, SettingsConstants.Option2Position.Y * Constant.DisplayScaleY), Color.White));
            Options.Add(new SetPrincessZeldaOOT(new Vector2(SettingsConstants.Option3Position.X * Constant.DisplayScaleX, SettingsConstants.Option3Position.Y * Constant.DisplayScaleY), Color.White));
            Options.Add(new SetDragonRoostIslandWindWaker(new Vector2(SettingsConstants.Option4Position.X * Constant.DisplayScaleX, SettingsConstants.Option4Position.Y * Constant.DisplayScaleY), Color.White));
            Options.Add(new SetGreatFairyFountain(new Vector2(SettingsConstants.Option5Position.X * Constant.DisplayScaleX, SettingsConstants.Option5Position.Y * Constant.DisplayScaleY), Color.White));
            Options.Add(new SetHyruleFieldOOTMusic(new Vector2(SettingsConstants.Option6Position.X * Constant.DisplayScaleX, SettingsConstants.Option6Position.Y * Constant.DisplayScaleY), Color.White));
            Options.Add(new SetKakarikoVillageOOTMusic(new Vector2(SettingsConstants.Option7Position.X * Constant.DisplayScaleX, SettingsConstants.Option7Position.Y * Constant.DisplayScaleY), Color.White));
            Options.Add(new SetLoruleCastleALinkBetweenWorldsMusic(new Vector2(SettingsConstants.Option8Position.X * Constant.DisplayScaleX, SettingsConstants.Option8Position.Y * Constant.DisplayScaleY), Color.White));
            Options.Add(new SetMidnasLamentTwilightPrincess(new Vector2(SettingsConstants.Option9Position.X * Constant.DisplayScaleX, SettingsConstants.Option9Position.Y * Constant.DisplayScaleY), Color.White));
            Options.Add(new SetWindWakerTheme(new Vector2(SettingsConstants.Option10Position.X * Constant.DisplayScaleX, SettingsConstants.Option10Position.Y * Constant.DisplayScaleY), Color.White));
            Options.Add(new SetZeddLegendOfZeldaHD(new Vector2(SettingsConstants.Option11Position.X * Constant.DisplayScaleX, SettingsConstants.Option11Position.Y * Constant.DisplayScaleY), Color.White));
            Options.Add(new SetBOTWTheme(new Vector2(SettingsConstants.Option12Position.X * Constant.DisplayScaleX, SettingsConstants.Option12Position.Y * Constant.DisplayScaleY), Color.White));


            background = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            background.SetData(new Color[] { Color.Black });

        }



          
     

   
/*            sb.DrawString(font, "m - Mute Music", new Vector2(150, 590), Color.White);
            sb.DrawString(font, "PageUp - Volume Up", new Vector2(150, 610), Color.White);
            sb.DrawString(font, "PageUp - Volume Down", new Vector2(150, 630), Color.White);
*/
        
    }
}
