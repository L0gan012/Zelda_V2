using System;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface IItemSelector
    {
        //IUsableItem Selected { get; }

        void SelectUp();

        void SelectDown();

        void SelectRight();

        void SelectLeft();

        void Update();

        void Draw(SpriteBatch spriteBatch);
    }
}
