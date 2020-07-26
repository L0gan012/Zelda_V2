using System;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface ISettingsPage
    {
        void selectOption();

        void cycleOption();

        void Update();

        void Draw(SpriteBatch spriteBatch, SpriteFont spriteFont);
    }
}
