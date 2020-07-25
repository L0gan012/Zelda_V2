using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public interface IMap
    {
        void Update();

        void Draw(SpriteBatch spriteBatch);
    }
}
