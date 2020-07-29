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
            Options.Add(new SetGerudoValley(SettingsConstants.MusicPosition1, Color.White));
            Options.Add(new SetLostWoodsOOT(SettingsConstants.MusicPosition2, Color.White));
            Options.Add(new SetPrincessZeldaOOT(SettingsConstants.MusicPosition3, Color.White));
            Options.Add(new SetDragonRoostIslandWindWaker(SettingsConstants.MusicPosition4, Color.White));
            Options.Add(new SetGreatFairyFountain(SettingsConstants.MusicPosition5, Color.White));
            Options.Add(new SetHyruleFieldOOTMusic(SettingsConstants.MusicPosition6, Color.White));
            Options.Add(new SetKakarikoVillageOOTMusic(SettingsConstants.MusicPosition7, Color.White));
            Options.Add(new SetLoruleCastleALinkBetweenWorldsMusic(SettingsConstants.MusicPosition8, Color.White));
            Options.Add(new SetMidnasLamentTwilightPrincess(SettingsConstants.MusicPosition9, Color.White));
            Options.Add(new SetWindWakerTheme(SettingsConstants.MusicPosition10, Color.White));
            Options.Add(new SetZeddLegendOfZeldaHD(SettingsConstants.MusicPosition11, Color.White));
            Options.Add(new SetBOTWTheme(SettingsConstants.MusicPosition12, Color.White));


            background = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            background.SetData(new Color[] { Color.Black });

        }



          
     

   
/*            sb.DrawString(font, "m - Mute Music", new Vector2(150, 590), Color.White);
            sb.DrawString(font, "PageUp - Volume Up", new Vector2(150, 610), Color.White);
            sb.DrawString(font, "PageUp - Volume Down", new Vector2(150, 630), Color.White);
*/
        
    }
}
