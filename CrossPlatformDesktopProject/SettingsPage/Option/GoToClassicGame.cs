﻿
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class GoToClassicGame : AbstractOption
    {
        public GoToClassicGame(Vector2 position, Color color)
        {
            Position = position;
            Color = color;
        }

        public override void Select()
        {
            AddToPageStack();
            Game1.Instance.State = new StateClassicGame();
        }

        public override void Draw(SpriteBatch spriteBatch, SpriteFont spriteFont)
        {
            spriteBatch.DrawString(spriteFont, "New Classic Dungeon", Position, Color);
        }
    }
}