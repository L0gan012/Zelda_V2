using System;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface IHealthBar
    {
        void Update();

        void Draw(SpriteBatch spriteBatch);
    }
}
