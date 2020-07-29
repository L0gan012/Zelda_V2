using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class StartPage : AbstractSettingsPage
    {
        public StartPage()
        {
            Options.Add(new GoToGameSelection(new Vector2(SettingsConstants.GameStartOptionPosition.X * Constant.DisplayScaleX, SettingsConstants.GameStartOptionPosition.Y * Constant.DisplayScaleY), Color.Black));
            background = Game1.Instance.Content.Load<Texture2D>("TextureSheets/SpriteSourceFiles/StartSheet");

        }

        public override void Draw(SpriteBatch spriteBatch, SpriteFont spriteFont)
        {
            spriteBatch.Draw(background, new Rectangle(0, 0, (int)(Constant.OriginalNesWidth * Constant.DisplayScaleX), (int)(Constant.OriginalNesHeight * Constant.DisplayScaleY)), Color.White);

            foreach (IOption option in Options)
            {
                option.Draw(spriteBatch, spriteFont);
            }
        }
    }
}
