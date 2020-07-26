using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface IOption
    {
        Vector2 Position { get; }

        void Select();

        void Update();

        void Draw(SpriteBatch spriteBatch, SpriteFont spriteFont);
    }
}
