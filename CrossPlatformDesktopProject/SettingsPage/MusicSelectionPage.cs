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
            Options.Add(new SetGerudoValley(Constant.Option1Position, Color.White));
            Options.Add(new SetLostWoodsOOT(Constant.Option2Position, Color.White));
            Options.Add(new SetPrincessZeldaOOT(Constant.Option3Position, Color.White));
            Options.Add(new SetDragonRoostIslandWindWaker(Constant.Option4Position, Color.White));
            Options.Add(new SetGreatFairyFountain(Constant.Option5Position, Color.White));
            Options.Add(new SetHyruleFieldOOTMusic(Constant.Option6Position, Color.White));
            Options.Add(new SetKakarikoVillageOOTMusic(Constant.Option7Position, Color.White));
            Options.Add(new SetLoruleCastleALinkBetweenWorldsMusic(Constant.MusicOption1Position, Color.White));
            Options.Add(new SetMidnasLamentTwilightPrincess(Constant.Option9Position, Color.White));
            Options.Add(new SetWindWakerTheme(Constant.Option10Position, Color.White));
            Options.Add(new SetZeddLegendOfZeldaHD(Constant.Option11Position, Color.White));
            Options.Add(new SetBOTWTheme(Constant.Option12Position, Color.White));


            background = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            background.SetData(new Color[] { Color.Black });

        }



          
     

   
/*            sb.DrawString(font, "m - Mute Music", new Vector2(150, 590), Color.White);
            sb.DrawString(font, "PageUp - Volume Up", new Vector2(150, 610), Color.White);
            sb.DrawString(font, "PageUp - Volume Down", new Vector2(150, 630), Color.White);
*/
        
    }
}
