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
            spriteBatch.DrawString(spriteFont, "tab - Up & Down", new Vector2(SettingsConstants.TabInstructionPosition.X * Constant.DisplayScaleX, SettingsConstants.TabInstructionPosition.Y * Constant.DisplayScaleY), Color.White);
            spriteBatch.DrawString(spriteFont, "space - Select Option", new Vector2(SettingsConstants.SpaceInstructionPosition.X * Constant.DisplayScaleX, SettingsConstants.SpaceInstructionPosition.Y * Constant.DisplayScaleY), Color.White);
            spriteBatch.DrawString(spriteFont, "B - Go Back", new Vector2(SettingsConstants.GoBackInstructionPosition.X * Constant.DisplayScaleX, SettingsConstants.GoBackInstructionPosition.Y * Constant.DisplayScaleY), Color.White);
            
            spriteBatch.DrawString(spriteFont, "Gamepad Controls", new Vector2(0, 100), Color.White);
            spriteBatch.DrawString(spriteFont, "Movement: Dpad Left Right Up Down", new Vector2(50, 120), Color.White);
            spriteBatch.DrawString(spriteFont, "A||X - Attack", new Vector2(50, 140), Color.White);
            spriteBatch.DrawString(spriteFont, "B||O - Back", new Vector2(50, 160), Color.White);
            spriteBatch.DrawString(spriteFont, "X||[] - Secondary Item", new Vector2(50, 180), Color.White);
            spriteBatch.DrawString(spriteFont, "Y||/\\ - Select Option", new Vector2(50, 200), Color.White);
            spriteBatch.DrawString(spriteFont, "Start - Pause", new Vector2(50, 220), Color.White);
            spriteBatch.DrawString(spriteFont, "Start -> Left Stick Click - Setting Menu", new Vector2(50, 240), Color.White);
            spriteBatch.DrawString(spriteFont, "Right Stick Click - Cycle Options", new Vector2(50, 260), Color.White);


            spriteBatch.DrawString(spriteFont, "Keyboard Contorls", new Vector2(0, 300), Color.White);
            spriteBatch.DrawString(spriteFont, "Movement: Keyboard Left Right Up Down", new Vector2(50, 320), Color.White);
            spriteBatch.DrawString(spriteFont, "Movement: Keyboard W S D A", new Vector2(50, 340), Color.White);
            spriteBatch.DrawString(spriteFont, "X && N - Attack", new Vector2(50, 360), Color.White);
            spriteBatch.DrawString(spriteFont, "Z - Secondary Item", new Vector2(50, 380), Color.White);
            spriteBatch.DrawString(spriteFont, "Enter - Pause", new Vector2(50, 400), Color.White);
            spriteBatch.DrawString(spriteFont, "Enter -> P - Setting Menu", new Vector2(50, 420), Color.White);
            spriteBatch.DrawString(spriteFont, "R - Reset Game", new Vector2(50, 440), Color.White);


        }

    }
}
