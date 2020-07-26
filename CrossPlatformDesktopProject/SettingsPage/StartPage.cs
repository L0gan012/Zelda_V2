using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class StartPage : AbstractSettingsPage
    {
        public StartPage()
        {
            //add options
            Options.Add(new GoToGameSelection(Constant.GameStartOptionPosition, Color.Black));

            background = Game1.Instance.Content.Load<Texture2D>("TextureSheets/SpriteSourceFiles/StartSheet");
            SoundManager.Instance.PlayIntroMusic();
        }

        public override void Draw(SpriteBatch spriteBatch, SpriteFont spriteFont)
        {
            spriteBatch.Draw(background, rect, Color.White);

            foreach (IOption option in Options)
            {
                option.Draw(spriteBatch, spriteFont);
            }
        }
    }
}
