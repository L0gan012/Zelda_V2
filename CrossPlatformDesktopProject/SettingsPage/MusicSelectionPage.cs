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


        public override void Draw(SpriteBatch spriteBatch, SpriteFont spriteFont)
        {
            spriteBatch.Draw(background, new Rectangle(0, 0, (int)(Constant.OriginalNesWidth * Constant.DisplayScaleX), (int)(Constant.OriginalNesHeight * Constant.DisplayScaleY)), Color.White);

            spriteBatch.DrawString(spriteFont, Title, new Vector2(SettingsConstants.TitlePosition.X * Constant.DisplayScaleX, SettingsConstants.TitlePosition.Y * Constant.DisplayScaleY), Color.White);

            foreach (IOption option in Options)
            {
                option.Draw(spriteBatch, spriteFont);
            }

            Fairy.Draw(spriteBatch, SettingsConstants.FairySelectorColor, FairyPosition);

            //Positions need to be fixed for "tab, space, and b drawing"
          /*  spriteBatch.DrawString(spriteFont, "tab - Up & Down", new Vector2(SettingsConstants.TabInstructionPosition.X * Constant.DisplayScaleX, SettingsConstants.TabInstructionPosition.Y * Constant.DisplayScaleY), Color.White);
            spriteBatch.DrawString(spriteFont, "space - Select Option", new Vector2(SettingsConstants.SpaceInstructionPosition.X * Constant.DisplayScaleX, SettingsConstants.SpaceInstructionPosition.Y * Constant.DisplayScaleY), Color.White);
            spriteBatch.DrawString(spriteFont, "B - Go Back", new Vector2(SettingsConstants.GoBackInstructionPosition.X * Constant.DisplayScaleX, SettingsConstants.GoBackInstructionPosition.Y * Constant.DisplayScaleY), Color.White);*/
            spriteBatch.DrawString(spriteFont, "m - Mute Music", new Vector2(150, 590), Color.White);
            spriteBatch.DrawString(spriteFont, "PageUp - Volume Up", new Vector2(150, 610), Color.White);
            spriteBatch.DrawString(spriteFont, "PageUp - Volume Down", new Vector2(150, 630), Color.White);
        }






    }
}
