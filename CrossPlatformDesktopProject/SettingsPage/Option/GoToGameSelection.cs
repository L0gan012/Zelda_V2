﻿
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class GoToGameSelection : AbstractOption
    {
        public GoToGameSelection(Vector2 position, Color color)
        {
            Position = position;
            Color = color;
        }

        public override void Select()
        {
            AddToPageStack();

            if(Game1.Instance.State is StateSettings)
            {
                ((StateSettings)Game1.Instance.State).SettingsPage = new GameSelectionPage();
            }
        }

        public override void Draw(SpriteBatch spriteBatch, SpriteFont spriteFont)
        {
            spriteBatch.DrawString(spriteFont, StringConstants.PressSpace, Position, Color);
        }
    }
}
