using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
namespace Sprint2
{
    public class InstructionsPage : AbstractSettingsPage
    {

        public InstructionsPage()
        {
            Title = StringConstants.Instructions;

            Options.Add(new GoToInstructionsPage2(new Vector2(SettingsConstants.Page2Position.X * Constant.DisplayScaleX, SettingsConstants.Page2Position.Y * Constant.DisplayScaleY), Color.White));
            
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

            spriteBatch.DrawString(spriteFont, StringConstants.KeyboardControls, new Vector2(SettingsConstants.KeyboardControlInstructionPosition.X * Constant.DisplayScaleX, SettingsConstants.KeyboardControlInstructionPosition.Y *  Constant.DisplayScaleY), Color.White);

            foreach(IController controller in Game1.Instance.Controllers)
            {
                if(controller is KeyboardController)
                {
                    ((KeyboardController)controller).DrawKeysAndDescriptions(spriteBatch, spriteFont, new Vector2(SettingsConstants.InstructionListStartPosition.X * Constant.DisplayScaleX, SettingsConstants.InstructionListStartPosition.Y * Constant.DisplayScaleY), Color.White);
                }
            }
        }
    }
}
