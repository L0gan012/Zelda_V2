using System;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface IItemSelector
    {
        void SelectForward();

        void SelectBack();

        void Update();

        void Draw(SpriteBatch spriteBatch);
    }
}
