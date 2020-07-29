using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
namespace Sprint2
{
    public class InstructionsPage : AbstractSettingsPage
    {

        public InstructionsPage()
        {

            Title = "Instructions";

            
            //No Need to add options page does not do anything but display current controls

            
            background = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            background.SetData(new Color[] { Color.Black });

        }


        public override void Draw(SpriteBatch spriteBatch, SpriteFont spriteFont)
        {
            spriteBatch.Draw(background, new Rectangle(0, 0, (int)(Constant.OriginalNesWidth * Constant.DisplayScaleX), (int)(Constant.OriginalNesHeight * Constant.DisplayScaleY)), Color.White);

            spriteBatch.DrawString(spriteFont, Title, new Vector2(SettingsConstants.TitlePosition.X * Constant.DisplayScaleX, SettingsConstants.TitlePosition.Y * Constant.DisplayScaleY), Color.White);


           

            //Positions need to be fixed for "tab, space, and b drawing"
          /*spriteBatch.DrawString(spriteFont, "tab - Up & Down", new Vector2(SettingsConstants.TabInstructionPosition.X * Constant.DisplayScaleX, SettingsConstants.TabInstructionPosition.Y * Constant.DisplayScaleY), Color.White);
            spriteBatch.DrawString(spriteFont, "space - Select Option", new Vector2(SettingsConstants.SpaceInstructionPosition.X * Constant.DisplayScaleX, SettingsConstants.SpaceInstructionPosition.Y * Constant.DisplayScaleY), Color.White);
            spriteBatch.DrawString(spriteFont, "B - Go Back", new Vector2(SettingsConstants.GoBackInstructionPosition.X * Constant.DisplayScaleX, SettingsConstants.GoBackInstructionPosition.Y * Constant.DisplayScaleY), Color.White);*/
            
            spriteBatch.DrawString(spriteFont, "Gamepad Controls", new Vector2(0, 100), Color.White);
            spriteBatch.DrawString(spriteFont, "Movement: Dpad Left Right Up Down", new Vector2(0, 120), Color.White);
            spriteBatch.DrawString(spriteFont, "A||X - Attack", new Vector2(0, 140), Color.White);
            spriteBatch.DrawString(spriteFont, "B||O - Back", new Vector2(0, 160), Color.White);
            spriteBatch.DrawString(spriteFont, "X||[] - Second Item", new Vector2(0, 180), Color.White);
            spriteBatch.DrawString(spriteFont, "Y||/\\ - Select", new Vector2(0, 180), Color.White);

            //spriteBatch.DrawString(spriteFont, "Keyboard Contorls", new Vector2(0, 120), Color.White);
            //spriteBatch.DrawString(spriteFont, "Mouse Controls", new Vector2(0, 140), Color.White);
        }






    }
}
