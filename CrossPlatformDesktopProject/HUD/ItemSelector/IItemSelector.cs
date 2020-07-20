using System;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface IItemSelector
    {
        IItem SelectedItem { get; }

        void SelectForward();

        void Update();

        void Draw(SpriteBatch spriteBatch);
    }
}
