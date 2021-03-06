﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
namespace Sprint2
{
    public class InstructionsPage2 : AbstractSettingsPage
    {

        public InstructionsPage2()
        {
            Title = StringConstants.Instructions;

            background = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            background.SetData(new Color[] { Color.Black });
        }


        public override void Draw(SpriteBatch spriteBatch, SpriteFont spriteFont)
        {
            spriteBatch.Draw(background, new Rectangle(0, 0, (int)(Constant.OriginalNesWidth * Constant.DisplayScaleX), (int)(Constant.OriginalNesHeight * Constant.DisplayScaleY)), Color.White);

            spriteBatch.DrawString(spriteFont, Title, new Vector2(SettingsConstants.TitlePosition.X * Constant.DisplayScaleX, SettingsConstants.TitlePosition.Y * Constant.DisplayScaleY), Color.White);
            
            spriteBatch.DrawString(spriteFont, "tab - Up & Down", new Vector2(SettingsConstants.TabInstructionPosition.X * Constant.DisplayScaleX, SettingsConstants.TabInstructionPosition.Y * Constant.DisplayScaleY), Color.White);
            spriteBatch.DrawString(spriteFont, "space - Select Option", new Vector2(SettingsConstants.SpaceInstructionPosition.X * Constant.DisplayScaleX, SettingsConstants.SpaceInstructionPosition.Y * Constant.DisplayScaleY), Color.White);
            spriteBatch.DrawString(spriteFont, "B - Go Back", new Vector2(SettingsConstants.GoBackInstructionPosition.X * Constant.DisplayScaleX, SettingsConstants.GoBackInstructionPosition.Y * Constant.DisplayScaleY), Color.White);

            spriteBatch.DrawString(spriteFont, "Gamepad Controls", new Vector2(0, 100), Color.White);
            spriteBatch.DrawString(spriteFont, "Movement: Dpad Left Right Up Down", new Vector2(50, 120), Color.White);
            spriteBatch.DrawString(spriteFont, "A or X - Attack", new Vector2(50, 140), Color.White);
            spriteBatch.DrawString(spriteFont, "B or O - Back", new Vector2(50, 160), Color.White);
            spriteBatch.DrawString(spriteFont, "X or  [] - Secondary Item", new Vector2(50, 180), Color.White);
            spriteBatch.DrawString(spriteFont, "Y or /\\ - Select Option", new Vector2(50, 200), Color.White);
            spriteBatch.DrawString(spriteFont, "Start - Pause", new Vector2(50, 220), Color.White);
            spriteBatch.DrawString(spriteFont, "Start -> Left Stick Click - Setting Menu", new Vector2(50, 240), Color.White);
            spriteBatch.DrawString(spriteFont, "Right Stick Click - Cycle Options", new Vector2(50, 260), Color.White);
        }
    }
}
